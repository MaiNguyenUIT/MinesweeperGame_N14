﻿using System;
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
    public partial class Form_PasswordChanged : KryptonForm
    {
        public static string tk = "";
        public static string mk = "";
        public Form_PasswordChanged()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
        }

        private void Form_PasswordChanged_FormClosed(object sender, FormClosedEventArgs e)
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
            return tk + "-" + mk + "-" + txt_NewPass.Text + "-" + "Doi MK";
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
            if (txt_NewPass.Text != string.Empty)
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

                    if (message == "Doi mat khau thanh cong")
                    {
                        label_tb.Text = "Đổi mật khẩu thành công";
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
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Connect();
            if(String.Compare(txt_NewPass.Text, txt_ReType.Text, false) != 0)
            {
                label_tb.Text = "Mật khẩu không khớp xin vui lòng nhập lại !!!";
                return;
            }
            if(String.Compare(mk, txt_MK.Text, false) != 0)
            {
                label_tb.Text = "Mật khẩu không đúng xin vui lòng nhập lại !!!";
                return;
            }
            Send();
        }
    }
}
