using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minesweeper_Client
{
    public partial class Form_Ranked : KryptonForm
    {
        public static string tk = "";
        public static string mk = "";

        public Form_Ranked()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
            SendToGetInf();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        IPEndPoint IP;
        Socket client;

        //kết nối đến server
        void Connect()
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //bắt đầu kết nôi. Nếu ko kết nối được thì hiện thông báo
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void SendToGetInf()
        {
            String str = tk + "-" + mk + "-" + "GetInf";
            client.Send(Serialize(str));
        }
        //đóng kết nối đến server
        void Close()
        {
            client.Close();
        }

        //gửi dữ liệu

        //nhận dữ liệu
        void Receive()
        {
            try
            {
                string[] message;
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string Str = (string)Deseriliaze(data);
                    message = Str.Split('-');
                    switch(message[message.Length - 1])
                    {
                        case "GetBeginner":
                            {
                                InsertDataIntoBeginner(Str);
                                break;
                            }
                        case "GetIntermediate":
                            {
                                InsertDataIntoIntermediate(Str);
                                break;
                            }
                        case "GetExpert":
                            {
                                InsertDataIntoExpert(Str);
                                break ;
                            }
                        default:
                            {
                                lblName.Text = message[1];
                                lbl_ID.Text = message[0].ToString();
                                break;
                            }
                    }
                }
            }
            catch
            {
                Close();
            }
        }

        void InsertDataIntoBeginner(string str)
        {
            string[] message;
            message = str.Split('-');
            int top = 1;
            for (int i = 0; i < message.Length; i = i + 2)
            {
                ListViewItem listViewItem = new ListViewItem(top.ToString());
                listViewItem.SubItems.Add(message[i]);
                listViewItem.SubItems.Add(message[i + 1]);
                listView_Beginner.Items.Add(listViewItem);
                top = top + 1;
            }
        }

        void InsertDataIntoIntermediate(string str)
        {
            string[] message;
            message = str.Split('-');
            int top = 1;
            for (int i = 0; i < message.Length; i = i + 2)
            {
                ListViewItem listViewItem = new ListViewItem(top.ToString());
                listViewItem.SubItems.Add(message[i]);
                listViewItem.SubItems.Add(message[i + 1]);
                listView_Mediate.Items.Add(listViewItem);
                top = top + 1;
            }
        }

        void InsertDataIntoExpert(string str)
        {
            string[] message;
            message = str.Split('-');
            int top = 1;
            for (int i = 0; i < message.Length; i = i + 2)
            {
                ListViewItem listViewItem = new ListViewItem(top.ToString());
                listViewItem.SubItems.Add(message[i]);
                listViewItem.SubItems.Add(message[i + 1]);
                listView_Expert.Items.Add(listViewItem);
                top = top + 1;
            }
        }

        //add mesage vào khung chat

        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        byte[] Serialize(object obj)
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy rồi cbi gửi đi
            return stream.ToArray();
        }

        //Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string để hiện thị lên màn hình
        object Deseriliaze(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data);
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Beginner_Click(object sender, EventArgs e)
        {
            Connect();
            String str = "Beginner" + "-" + "GetRank";
            listView_Beginner.Items.Clear();
            client.Send(Serialize(str));
        }

        private void btn_Intermediate_Click(object sender, EventArgs e)
        {
            Connect();
            String str = "Intermediate" + "-" + "GetRank";
            listView_Mediate.Items.Clear();
            client.Send(Serialize(str));
        }

        private void btn_Expert_Click(object sender, EventArgs e)
        {
            Connect();
            String str = "Expert" + "-" + "GetRank";
            listView_Expert.Items.Clear();
            client.Send(Serialize(str));
        }
    }
}
