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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SERVER
{
    public partial class Form1: Form
    {
        private string connStr = @"Data Source=DESKTOP-OQT6SUJ;Initial Catalog=DOAN_LTTQ;Integrated Security=True";
        private SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        IPEndPoint IP;
        Socket server;
        //khai báo 1 list các client
        List<Socket> clientList;

        //kết nối đến server
        void Connect()
        {
            clientList = new List<Socket>();//khởi tạo 1 list nhiều client
            //khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Any, 1997);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //đợi kết nối từ client
            server.Bind(IP);
            //tạo 1 luồng lăng nghe từ client
            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();//nếu lăng nghe thành công thì server chấp nhận kết nối
                        clientList.Add(client);//thêm các client được server accept vào list
                        //tạo luồng nhận thông tin từ client
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                /*khi kết nối đến n client mà có 1 client disconnect thì server sẽ chạy vòng lặp while liên tục để
                 chương trình ko bị crash*/
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 1997);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        //đóng kết nối đến server
        void Close()
        {
            server.Close();
        }

        //gửi dữ liệu
        void Send(Socket client)
        {
            //nếu textboc khác rỗng thì mới gửi tin
            
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
        //nhận dữ liệu
        void Receive(object obj)
        {
            Random random1 = new Random();
            int ID = random1.Next(random1.Next(100000 - (999999 - 1) + 999999));          
            SqlCommand sqlCommand;         
            SqlDataReader sqlDataReader;
            Socket client = obj as Socket;
            try
            {
                string[] message;
                while (true)
                {
                    //khởi tạo mảng byte để nhận dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string Str = (string)Deseriliaze(data);
                    message = Str.Split('-');
                    //khi 1 client gửi thì cả server và các client (ngoại trừ thằng client vừa gửi) cùng nhận đc
                    if (message[message.Length - 1] == "Dang Ki")
                    {
                        int STT = ID;
                        string TK = message[0];
                        string MK = message[1];
                        string HoTen = message[2];
                        string Gmail = message[3];
                        string GioiTinh = message[4];
                        string query = "Select * from User_Inf where taikhoan = '" + TK + "'";

                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader.GetString(0) != null)
                            {
                                client.Send(Serialize("That bai"));
                                sqlDataReader.Close();
                                return;
                            }
                        }
                        sqlDataReader.Close();
                        string query_1 = @"Insert into User_Inf values ( '" + STT + "','" + message[0] + "','" + message[1] + "','" + message[3] + "','" + message[2] + "','" + message[4] + "','" + "none" + "','" + "off" + "')";
                        
                        SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                        sqlCommand1.ExecuteNonQuery();
                        client.Send(Serialize("Thanh cong"));
                    }

                    if (message[message.Length - 1] == "Dang Nhap")
                    {
                        string query = "Select * from User_Inf where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            if (sqlDataReader.GetString(1) != null)
                            {                               
                                if (String.Compare(sqlDataReader.GetString(7), "on", false) == 0)
                                {
                                    client.Send(Serialize("4"));
                                    sqlDataReader.Close();
                                    return;
                                }
                                sqlDataReader.Close();
                                string query_ig = "Select * from User_Inf where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "' and ingame = 'none'";
                                SqlCommand sqlCommand1 = new SqlCommand(query_ig, conn);
                                SqlDataReader sqlDataReader1;
                                sqlDataReader1 = sqlCommand1.ExecuteReader();
                                if (sqlDataReader1.Read())
                                {
                                    if (sqlDataReader1.GetString(1) != null)
                                    {
                                        client.Send(Serialize("3"));
                                        sqlDataReader1.Close();
                                        return;
                                    }                                   
                                }
                                sqlDataReader1.Close();
                                string query_1 = "Update User_Inf set mode = '" + "on" + "' where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "'";
                                SqlCommand sqlCommand2 = new SqlCommand(query_1, conn);
                                sqlCommand2.ExecuteNonQuery();
                                client.Send(Serialize("1"));
                            }
                        }
                        else
                        {
                            client.Send(Serialize("2"));
                        }
                        sqlDataReader.Close();
                    }

                    if (message[message.Length - 1] == "Quen mat khau")
                    {
                        string query = "Select * from User_Inf where taikhoan = '" + message[0] + "' and gmail = '" + message[1] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader.GetString(1) == null)
                            {
                                client.Send(Serialize("Lay mat khau that bai"));
                                return;                              
                            }                        
                        }
                        sqlDataReader.Close();
                        string newPass = HamTaoChuoi();
                        client.Send(Serialize(newPass + "-" + "Lay mat khau thanh cong"));
                        string query_1 = "Update User_Inf set matkhau = '" + newPass + "' where taikhoan = '" + message[0] + "' and gmail = '" + message[1] + "'";
                        SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                        sqlCommand1.ExecuteNonQuery();                        
                    }

                    if (message[message.Length - 1] == "Tao ingame")
                    {
                        string query = "Select * from User_Inf where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "' and ingame = '" + message[2] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            if (sqlDataReader.GetString(1) != null)
                            {
                                client.Send(Serialize("Tao ingame that bai"));
                                return;
                            }
                        }
                        sqlDataReader.Close();                       
                        string query_1 = "Update User_Inf set ingame = '" + message[2] + "' where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "'";
                        SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                        sqlCommand1.ExecuteNonQuery();
                        client.Send(Serialize("Tao ingame thanh cong"));
                    }

                    if (message[message.Length - 1] == "Doi MK")
                    {
                        client.Send(Serialize("Doi mat khau thanh cong"));
                        string query_1 = "Update User_Inf set matkhau = '" + message[2] + "' where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "'";
                        SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                        sqlCommand1.ExecuteNonQuery();
                    }

                    if (message[message.Length - 1] == "GetInf")
                    {
                        string query = "Select id, ingame from User_Inf where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            if (sqlDataReader.GetString(1) != null)
                            {
                                var id = sqlDataReader.GetInt32(0);
                                var ig = sqlDataReader.GetString(1);
                                string str = id + "-" + ig;
                                client.Send(Serialize(str));
                                sqlDataReader.Close();                       
                            }
                        }
                        sqlDataReader.Close();
                    }

                    if(message[message.Length - 1] == "Close")
                    {
                        string query_1 = "Update User_Inf set mode = '" + "off" + "' where taikhoan = '" + message[0] + "' and matkhau = '" + message[1] + "'";
                        SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                        sqlCommand1.ExecuteNonQuery();
                    }

                    if (message[message.Length - 1] == "KtraAttempt")
                    {
                        string query = "Select max(attempt) from User_Score where username = '" + message[0] + "' group by username";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            if (sqlDataReader.GetInt32(0).ToString() != null)
                            {               
                                var attempt = sqlDataReader.GetInt32(0);
                                client.Send(Serialize("Da choi" + "-" + attempt.ToString()));
                                sqlDataReader.Close();
                            }
                        }
                        else
                        {
                            client.Send(Serialize("Chua choi"));
                        }
                        sqlDataReader.Close();
                    }

                    if (message[message.Length - 1] == "AddScore")
                    {
                        string query_1 = @"Insert into User_Score values ( '" + message[0] + "','" + message[1] + "','" + message[2] + "','" + message[3] + "','" + message[4] + "')";
                        SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                        sqlCommand1.ExecuteNonQuery();
                    }

                    if (message[message.Length - 1] == "GetData")
                    {
                        List<string> attempt = new List<string>();
                        List<string> mode = new List<string>();
                        List<string> score = new List<string>();
                        List<string> time = new List<string>();
                        String str = "";
                        string query = "Select attempt, mode, score, time from User_Score where username = '" + message[0] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            var att = sqlDataReader.GetInt32(0);
                            var mod = sqlDataReader.GetString(1);
                            var scor = sqlDataReader.GetInt32(2);
                            var tim = sqlDataReader.GetString(3);
                            attempt.Add(att.ToString());
                            mode.Add(mod);
                            score.Add(scor.ToString());
                            time.Add(tim.ToString());
                        }
                        for(int i = 0; i < attempt.Count; i++)
                        {
                            if(i == attempt.Count - 1)
                            {
                                str += attempt[i] + "-" + mode[i] + "-" + score[i] + "-" + time[i] + "-" + "GetData";
                            }
                            else
                            {
                                str += attempt[i] + "-" + mode[i] + "-" + score[i] + "-" + time[i] + "-";
                            }
                        }
                        client.Send(Serialize(str));
                        sqlDataReader.Close();
                    }

                    if (message[message.Length - 1] == "GetRank")
                    {
                        if (message[0] == "Beginner")
                        {
                            List<string> name = new List<string>();
                            List<string> score = new List<string>();
                            String str = "";
                            string query = "select username, max(score) from User_Score where mode = 'beginner' group by username order by max(score) desc";
                            sqlCommand = new SqlCommand(query, conn);
                            sqlDataReader = sqlCommand.ExecuteReader();
                            while (sqlDataReader.Read())
                            {
                                var nam = sqlDataReader.GetString(0);
                                var scor = sqlDataReader.GetInt32(1).ToString();
                                name.Add(nam);
                                score.Add(scor);
                            }
                            for(int i = 0; i < name.Count; i++)
                            {
                                if(i == name.Count - 1)
                                {
                                    str += name[i] + "-" + score[i] + "-" + "GetBeginner";
                                }
                                else
                                {
                                    str += name[i] + "-" + score[i] + "-";
                                }
                            }
                            client.Send(Serialize(str));
                            sqlDataReader.Close();
                        }

                        if (message[0] == "Intermediate")
                        {
                            List<string> name = new List<string>();
                            List<string> score = new List<string>();
                            String str = "";
                            string query = "select username, max(score) from User_Score where mode = 'medium' group by username order by max(score) desc";
                            sqlCommand = new SqlCommand(query, conn);
                            sqlDataReader = sqlCommand.ExecuteReader();
                            while (sqlDataReader.Read())
                            {
                                var nam = sqlDataReader.GetString(0);
                                var scor = sqlDataReader.GetInt32(1).ToString();
                                name.Add(nam);
                                score.Add(scor);
                            }
                            for (int i = 0; i < name.Count; i++)
                            {                    
                                if (i == name.Count - 1)
                                {
                                    str += name[i] + "-" + score[i] + "-" + "GetIntermediate";
                                }
                                else
                                {
                                    str += name[i] + "-" + score[i] + "-";
                                }
                            }                
                            client.Send(Serialize(str));
                            sqlDataReader.Close();
                        }

                        if (message[0] == "Expert")
                        {
                            List<string> name = new List<string>();
                            List<string> score = new List<string>();
                            String str = "";
                            string query = "select username, max(score) from User_Score where mode = 'expert' group by username order by max(score) desc";
                            sqlCommand = new SqlCommand(query, conn);
                            sqlDataReader = sqlCommand.ExecuteReader();
                            while (sqlDataReader.Read())
                            {
                                var nam = sqlDataReader.GetString(0);
                                var scor = sqlDataReader.GetInt32(1).ToString();
                                name.Add(nam);
                                score.Add(scor);
                            }
                            for (int i = 0; i < name.Count; i++)
                            {
                                if (i == name.Count - 1)
                                {
                                    str += name[i] + "-" + score[i] + "-" + "GetExpert";
                                }
                                else
                                {
                                    str += name[i] + "-" + score[i] + "-";
                                }
                            }
                            client.Send(Serialize(str));
                            sqlDataReader.Close();
                        }
                    }

                    if (message[message.Length - 1] == "Addfr")
                    {
                        string query = "Select id from User_Inf where ingame = '" + message[1] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        bool is_null = true;
                        var idfr = 0;
                        while (sqlDataReader.Read())
                        {
                            is_null = false;
                            if (sqlDataReader.GetInt32(0).ToString() != null)
                            {                               
                                idfr = sqlDataReader.GetInt32(0);
                            }
                        }
                        if(is_null == true)
                        {
                            string str = "User khong ton tai";
                            client.Send(Serialize(str));
                            break;
                        }
                        sqlDataReader.Close();
                        string query_1 = @"Insert into User_Friend values ( '" + message[1] + "','" + message[0] + "','" + "wait" + "'," + message[2] + ")";
                        string query_2 = @"Insert into User_Friend values ( '" + message[0] + "','" + message[1] + "','" + "wait" + "'," + idfr.ToString() + ")";
                        SqlCommand sqlCommand2 = new SqlCommand(query_1, conn);
                        SqlCommand sqlCommand1 = new SqlCommand(query_2, conn);
                        sqlCommand2.ExecuteNonQuery();
                        sqlCommand1.ExecuteNonQuery();
                    }

                    if (message[message.Length - 1] == "GetInvitation")
                    {
                        List<string> invition = new List<string>();
                        String str = "";
                        string query = "select username_fr from User_Friend where username = '" + message[0] + "'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            var inv = sqlDataReader.GetString(0);
                            invition.Add(inv);
                        }
                        for(int i = 0; i < invition.Count; i++)
                        {
                            if(i == invition.Count - 1)
                            {
                                str += invition[i];
                            }
                            else
                            {
                                str += invition[i] + "-";
                            }
                        }
                        client.Send(Serialize(str));
                        sqlDataReader.Close();
                    }

                    if (message[message.Length - 1] == "Action")
                    {
                        if (message[message.Length - 2] == "acp")
                        {
                            string query_1 = "Update User_Friend set status = '" + "done" + "' where username = '" + message[0] + "' and username_fr = '" + message[1] + "'";
                            string query_2 = "Update User_Friend set status = '" + "done" + "' where username = '" + message[1] + "' and username_fr = '" + message[0] + "'";
                            SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                            SqlCommand sqlCommand2 = new SqlCommand(query_2, conn);
                            sqlCommand1.ExecuteNonQuery();
                            sqlCommand2.ExecuteNonQuery();
                        }

                        if (message[message.Length - 2] == "deny")
                        {
                            string query_1 = "Delete from User_Friend where username = '" + message[0] + "' and username_fr = '" + message[1] + "'";
                            string query_2 = "Delete from User_Friend where username = '" + message[1] + "' and username_fr = '" + message[0] + "'";
                            SqlCommand sqlCommand1 = new SqlCommand(query_1, conn);
                            SqlCommand sqlCommand2 = new SqlCommand(query_2, conn);
                            sqlCommand1.ExecuteNonQuery();
                            sqlCommand2.ExecuteNonQuery();
                        }
                    }

                    if (message[message.Length - 1] == "GetFr")
                    {
                        List<string> username_fr = new List<string>();
                        List<string> id_fr = new List<string>();
                        String str = "";
                        string query = "select distinct username_fr, id from User_Friend where username = '" + message[0] + "' and status = 'done'";
                        sqlCommand = new SqlCommand(query, conn);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            var name_fr = sqlDataReader.GetString(0);
                            var id = sqlDataReader.GetInt32(1).ToString();
                            username_fr.Add(name_fr);
                            id_fr.Add(id);
                        }
                        for (int i = 0; i < username_fr.Count; i++)
                        {
                            if (i == username_fr.Count - 1)
                            {
                                str += username_fr[i] + "-" + id_fr[i] + "-" + "GetFr";
                            }
                            else
                            {
                                str += username_fr[i] + "-" + id_fr[i] + "-";
                            }
                        }
                        client.Send(Serialize(str));
                        sqlDataReader.Close();
                    }
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
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
    }
}
