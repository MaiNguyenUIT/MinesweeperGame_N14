using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Minesweeper_Client
{
    public partial class MineLand : Form
    {
        TimeSpan seconds;
        public string mode = "";
        public static string username = "";
        int attempt = 0;
     
        public MineLand()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            Connect();
            this.Text = Application.ProductName + " " + Application.ProductVersion;

            NewGame();
            SendToGetAttempt();
        }

        private void Form_PasswordChanged_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClose();
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
        void FormClose()
        {
            client.Close();
        }

        //gửi dữ liệu
        void SendToGetAttempt()
        {
            //nếu textbox khác rỗng thì mới gửi tin
            string str = username + "-" + "KtraAttempt";
            client.Send(Serialize(str));
        }

        void SendToAddScore()
        {
            string str = username + "-" + (attempt + 1).ToString() + "-" + mode + "-" + lblScores.Text + "-" + lblTime.Text + "-" + "AddScore";
            client.Send(Serialize(str));
        }

        //nhận dữ liệu
        void Receive()
        {
            string[] message;
            try
            {
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string str = (string)Deseriliaze(data);
                    message = str.Split('-');
                    if (message[0] == "Chua choi")
                    {
                        attempt = 0;
                    }
                    if (message[0] == "Da choi")
                    {
                        attempt = int.Parse(message[1]);
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


        //kết nối đến server

        //add mesage vào khung chat

        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void NewGame()
        {
            minesBoard1.NewGame();
            RenewForm();

        }
        private void NewGame(int rows, int cols, int mines)
        {
            minesBoard1.NewGame(rows, cols, mines);
            RenewForm();
            seconds = TimeSpan.Zero;
            timer1.Start();
        }
        private void RenewForm()
        {
            button1.BackgroundImage = Properties.Resources.face1;
            this.Height = minesBoard1.Height + 120;
            this.Width = minesBoard1.Width + 20;
            UpdateMines();
        }
        void UpdateMines()
        {
            lblMines.Text = String.Format("{0:000}", minesBoard1.MinesCount - minesBoard1.FlagsCount);
            if (minesBoard1.RemainCellsCount == minesBoard1.MinesCount)
                button1.BackgroundImage = Properties.Resources.face4;
        }
        void CheckMenuItem(ToolStripMenuItem menuItem)
        {
            if (menuItem != null)
            {
                foreach (var item in gameToolStripMenuItem1.DropDownItems)
                {
                    ToolStripMenuItem mi = item as ToolStripMenuItem;
                    if (mi != null)
                        mi.Checked = false;
                }
                menuItem.Checked = true;
            }
        }

        public void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "beginner";
            NewGame(10, 10, 10);
            CheckMenuItem(sender as ToolStripMenuItem);
        }

        public void intermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "medium";
            NewGame(16, 16, 40);
            CheckMenuItem(sender as ToolStripMenuItem);
        }

        public void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "expert";
            NewGame(25, 40, 200);
            CheckMenuItem(sender as ToolStripMenuItem);
        }

        public void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm(minesBoard1.Rows, minesBoard1.Cols, minesBoard1.MinesCount);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                NewGame(frm.Rows, frm.Cols, frm.Mines);
            }
            CheckMenuItem(sender as ToolStripMenuItem);

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = minesBoard1.MaskColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                minesBoard1.MaskColor = dlg.Color;
            }
        }

        private void minesBoard1_MinesExplode(object sender, EventArgs e)
        {
            SendToAddScore();
            button1.BackgroundImage = Properties.Resources.face3;
            timer1.Stop();
        }

        private void minesBoard1_CellClick(object sender, EventArgs e)
        {
            UpdateMines();
            lblScores.Text = minesBoard1.Scores.ToString();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("NOPE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minesBoard1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void minesBoard1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds = seconds.Add(TimeSpan.FromSeconds(1));
            lblTime.Text = seconds.ToString(@"mm\:ss");
        }
    }
}
