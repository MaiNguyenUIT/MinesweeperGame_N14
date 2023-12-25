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
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComponentFactory.Krypton.Toolkit;

namespace Minesweeper_Client
{
    public partial class Form_Forgotpass : KryptonForm
    {
        public Form_Forgotpass()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
        }

        private void FormQMK_FormClosed(object sender, FormClosedEventArgs e)
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

        //đóng kết nối đến server
        void Close()
        {
            client.Close();
        }

        string HamGhepChuoi()
        {
            return tbx_Account.Text + "-" + tbx_Gmail.Text + "-" + "Quen mat khau";
        }
        //gửi dữ liệu
        void Send()
        {
            //nếu textboc khác rỗng thì mới gửi tin
            if (tbx_Account.Text != string.Empty && tbx_Gmail.Text != string.Empty)
            {
                client.Send(Serialize(HamGhepChuoi()));
            }
        }

        bool checkAccount(string ac)//check tk mk
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{6,24}$");
        }

        bool checkMail(string gm)
        {
            return Regex.IsMatch(gm, @"^[\w]{3,20}@gmail.com(.vn|)$");
        }

        //nhận dữ liệu
        void Receive()
        {
            try
            {
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string message = (string)Deseriliaze(data);
                    string[] str = message.Split('-');
                    if (str[1] == "Lay mat khau thanh cong")
                    {
                        label4.Text = str[0];
                    }
                    if (message == "Lay mat khau that bai")
                    {
                        label4.Text = "Tài khoản hoặc gmail không chính xác";
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


        private void Getpassbtn_Click(object sender, EventArgs e)
        {
            if (checkAccount(tbx_Account.Text) != true)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài từ 6-24 kí tự bao, với các kí tự thường, in hoa, số");
                return;
            }
            if (checkMail(tbx_Gmail.Text) != true)
            {
                MessageBox.Show("Định dạng gmail không đúng xin vui lòng nhập lại");
                return;
            }
            Send();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            this.Hide();
            form.Show();
            this.Close();
        }
    }
}

