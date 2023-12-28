using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Admin_Work_Form_ForElse : Form
    {
        public Admin_Work_Form_ForElse()
        {
            InitializeComponent();
        }


        private void btbNext_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin_Login_Form form = new Admin_Login_Form();
            this.Hide();
            form.Show();
            this.Close();
        }

        private void user_ScoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_ScoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dOAN_LTTQDataSet);

        }

        private void Admin_Work_Form_ForElse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN_LTTQDataSet.User_Score' table. You can move, or remove it, as needed.
            this.user_ScoreTableAdapter.Fill(this.dOAN_LTTQDataSet.User_Score);

        }
    }
}
