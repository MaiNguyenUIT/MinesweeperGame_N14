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
namespace Minesweeper_Client
{
    public partial class MainForm : KryptonForm
    {
        public static int scores = 0;
        public string mode = "";
        public static string tk = "";
        public static string mk = "";
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
            SendtoGetinf();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            SendWhenClose();
            Thread.Sleep(500);
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

        string HamGhepChuoi()
        {
            return tk + "-" + mk;
        }
        //đóng kết nối đến server
        void Close()
        {
            client.Close();
        }

        //gửi dữ liệu

        void SendtoGetinf()
        {
            String str = HamGhepChuoi() + "-" + "GetInf";
            client.Send(Serialize(str));
        }

        void SendWhenClose()
        {
            String str = HamGhepChuoi() + "-" + "Close";
            client.Send(Serialize(str));
        }

        void SendToGetData()
        {
            String str = tk + "-" + "GetData";
            client.Send(Serialize(str));
        }

        void InsertDataIntoListView(string str)
        {
            string[] message;
            message = str.Split('-');
            for(int i = 0; i < message.Length; i = i + 4)
            {
                ListViewItem listViewItem = new ListViewItem(message[i]);
                listViewItem.SubItems.Add(message[i + 1]);
                listViewItem.SubItems.Add(message[i + 2]);
                listViewItem.SubItems.Add(message[i + 3]);
                listView1.Items.Add(listViewItem);
            }
        }

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
                    if (message[message.Length - 1] == "GetData")
                    {
                        InsertDataIntoListView(Str);
                    }
                    else
                    {
                        lblName.Text = message[1];
                        lbl_ID.Text = message[0].ToString();
                        MineLand.username = lblName.Text;
                    }
                }
            }
            catch
            {
                Close();
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
        private void btnCustom_Click(object sender, EventArgs e)
        {
            MineLand mineland = new MineLand();
            mineland.customToolStripMenuItem_Click(sender, e);
            mineland.ShowDialog();
        }

        private void btn_Quest_Click(object sender, EventArgs e)
        {
            string rulestr = "Mục tiêu chính: Mục tiêu của trò chơi là mở tất cả các ô trên bảng mà không chạm vào ô nào chứa mìn.\r\n\r\n" +
               "Bảng chơi: Trò chơi thường chơi trên một bảng ô vuông, mỗi ô có thể chứa một mìn hoặc không chứa mìn. Kích thước của bảng và số lượng mìn thường được người chơi chọn trước khi bắt đầu." + "\r\n\r\n" +
               "Mở ô: Bạn mở ô bằng cách nhấp chuột (hoặc cách khác tùy thuộc vào giao diện chơi) vào ô bạn muốn mở.\r\n\r\nSố trên ô: Nếu một ô không chứa mìn, nó sẽ hiển thị một con số, thường là từ 1 đến 8, biểu thị số lượng ô xung quanh có chứa mìn.\r\n\r\n" +
               "Mìn: Nếu bạn mở một ô chứa mìn, bạn thua cuộc và trò chơi kết thúc." + "\r\n\r\n" +
               "Cờ: Bạn có thể đặt một lá cờ trên một ô nếu bạn nghi ngờ rằng nó chứa mìn. Điều này giúp bạn nhớ và tránh mở những ô có thể chứa mìn.\r\n\r\n" +
               "Chọn cẩn thận: Hãy chọn cẩn thận khi mở các ô, dựa trên thông tin về số trên ô xung quanh để xác định liệu có mìn trong các ô lân cận hay không.\r\n\r\n" +
               "Winning: Bạn chiến thắng khi tất cả các ô không chứa mìn đều được mở.";
            string captionstr = "The rule of Minesweeper";
            MessageBox.Show(rulestr,captionstr, MessageBoxButtons.OK, MessageBoxIcon.Question);
            
        }
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            Form_Setting formSetting = new Form_Setting();
            formSetting.ShowDialog();
            
        }
        private void picB_MouseEnter(object sender, EventArgs e)
        {
             picB_Signout.BackColor = Color.LightGoldenrodYellow;
        }

        private void picB_MouseLeave(object sender, EventArgs e)
        {
            picB_Signout.BackColor = Color.Transparent;
        }

        private void btnBeginner_Click(object sender, EventArgs e)
        {
            MineLand mineland = new MineLand();
            mineland.beginnerToolStripMenuItem_Click(sender,e);
            mineland.ShowDialog();
        }

        

        private void btnIntermediate_Click(object sender, EventArgs e)
        {
            MineLand mineland = new MineLand();
            mineland.intermediateToolStripMenuItem_Click(sender, e);
            mineland.ShowDialog();
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            MineLand mineland = new MineLand();
            mineland.expertToolStripMenuItem_Click(sender, e);
            mineland.ShowDialog();
        }

        private void picB_Signout_Click(object sender, EventArgs e)
        {
            Connect();
            DialogResult dialogResult = MessageBox.Show("Sure", "Do u want to close", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SendWhenClose();
                Thread.Sleep(500);
                this.Hide();
                Form_Login form = new Form_Login();
                form.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Setting_MouseEnter(object sender, EventArgs e)
        {
            picB_Setting.BackColor = Color.PaleGoldenrod;
        }

        private void btn_Setting_MouseLeave(object sender, EventArgs e)
        {
            picB_Setting.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void btn_Quest_MouseEnter(object sender, EventArgs e)
        {
            picB_Quest.BackColor = Color.PaleGoldenrod;
        }

        private void btn_Quest_MouseLeave(object sender, EventArgs e)
        {
            picB_Quest.BackColor = SystemColors.GradientInactiveCaption;

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Connect();
            listView1.Items.Clear();
            SendToGetData();
        }

        private void picB_Ranked_Click(object sender, EventArgs e)
        {
            Form_Ranked form = new Form_Ranked();
            form.ShowDialog();
        }

        private void picB_Ranked_MouseEnter(object sender, EventArgs e)
        {
            picB_Ranked.BackColor = Color.PaleGoldenrod;
        }

        private void picB_Ranked_MouseLeave(object sender, EventArgs e)
        {
            picB_Ranked.BackColor= Color.Transparent;
        }
    }
}
