using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
namespace Admin
{
    public partial class Admin_MainWork_Form : KryptonForm
    {
        public Admin_MainWork_Form()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Work_Form_ForElse form_ForElse = new Admin_Work_Form_ForElse();
            form_ForElse.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin_Login_Form form = new Admin_Login_Form();
            this.Hide();
            form.Show();
            this.Close();
        }

        private void user_InfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_InfBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dOAN_LTTQDataSet);

        }

        private void Admin_MainWork_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAN_LTTQDataSet.User_Inf' table. You can move, or remove it, as needed.
            this.user_InfTableAdapter.Fill(this.dOAN_LTTQDataSet.User_Inf);

        }
    }
}
