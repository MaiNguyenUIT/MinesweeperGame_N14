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
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Minesweeper_Client
{
    public partial class Form_Login : KryptonForm
    {
        public Form_Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
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

        string HamGhepChuoi()
        {
            return tbx_Account.Text + "-" + tbx_Password.Text + "-" + "Dang Nhap";
        }
        //đóng kết nối đến server
        void Close()
        {
            client.Close();
        }

        //gửi dữ liệu
        void Send()
        {
            //nếu textboc khác rỗng thì mới gửi tin
            if (tbx_Account.Text != string.Empty && tbx_Password.Text != String.Empty)
            {
                client.Send(Serialize(HamGhepChuoi()));
            }
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

                    if (message == "1")
                    {
                        this.Hide();
                        MainForm form1 = new MainForm();
                        form1.ShowDialog();
                        this.Close();
                    }
                    if (message == "3")
                    {
                        Form_CreateGameCharacter form_CreateGameCharacter = new Form_CreateGameCharacter();
                        form_CreateGameCharacter.ShowDialog();
                    }
                    if (message == "2")
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu vui lòng nhập lại");
                    }
                    if(message == "4")
                    {
                        MessageBox.Show("Tài khoản hiện đang đăng nhập nơi khác xin vui lòng thử lại");
                        Connect();
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



        private void btn_Login_Click(object sender, EventArgs e)
        {           
            Send();
            Form_PasswordChanged.tk = tbx_Account.Text;
            Form_PasswordChanged.mk = tbx_Password.Text;
            Form_CreateGameCharacter.taikhoan = tbx_Account.Text;
            Form_CreateGameCharacter.matkhau = tbx_Password.Text;
            MainForm.tk = tbx_Account.Text;
            MainForm.mk = tbx_Password.Text;
            MineLand.tk = tbx_Account.Text;
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SignUp formDangKi = new Form_SignUp();
            formDangKi.ShowDialog();
            this.Close();
        }

        private void lklbl_ForgotPass_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            Form_Forgotpass formQMK = new Form_Forgotpass();
            formQMK.ShowDialog();
            this.Close();
        }
    }
}
