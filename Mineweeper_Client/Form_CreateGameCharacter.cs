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
    public partial class Form_CreateGameCharacter : KryptonForm
    {
        public static string taikhoan;
        public static string matkhau;
        string tk;
        string mk;
        public Form_CreateGameCharacter()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
            tk = taikhoan;
            mk = matkhau;
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

        string HamGhepChuoi()
        {
            return tk + "-" + mk + "-" + txt_ingame.Text + "-" + "Tao ingame";
        }
        //đóng kết nối đến server
        void Close()
        {
            client.Close();
        }

        //gửi dữ liệu
        void Send()
        {
            //nếu textbox khác rỗng thì mới gửi tin
            if (txt_ingame.Text != string.Empty)
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

                    if (message == "Tao ingame thanh cong")
                    {
                        label_ig.Text = "Tạo ingame thành công";                      
                        this.Hide();
                        this.Close();
                    }
                    else
                    {
                        label_ig.Text = "Ingame đã tồn tại xin vui lòng nhập lại";
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

        private void reset_Click(object sender, EventArgs e)
        {
            txt_ingame.Text = HamTaoChuoi();
        }

        public string HamTaoChuoi()
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder sb = new StringBuilder(8);
            for (int i = 0; i < 8; i++)
            {
                int type = random.Next(3); // 0: chữ thường, 1: chữ in hoa, 2: số
                switch (type)
                {
                    case 0:
                        sb.Append(chars[random.Next(26)]); // chọn chữ thường từ a đến z
                        break;
                    case 1:
                        sb.Append(chars[random.Next(26, 52)]); // chọn chữ in hoa từ A đến Z
                        break;
                    case 2:
                        sb.Append(chars[random.Next(52, 62)]); // chọn số từ 0 đến 9
                        break;
                }
            }

            return sb.ToString();
        }

        private void tao_ingame_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
