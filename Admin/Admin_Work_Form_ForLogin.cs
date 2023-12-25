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
    public partial class Admin_Work_Form_ForLogin : KryptonForm
    {
        public Admin_Work_Form_ForLogin()
        {
            InitializeComponent();
        }

        private void pLAYER_FRIENDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pLAYER_FRIENDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseOfMineSweeperDataSet);

        }

        private void Admin_Work_Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOfMineSweeperDataSet.PLAYER_LOGIN' table. You can move, or remove it, as needed.
            this.pLAYER_LOGINTableAdapter.Fill(this.databaseOfMineSweeperDataSet.PLAYER_LOGIN);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Work_Form_ForElse form = new Admin_Work_Form_ForElse();
            form.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin_Login_Form form = new Admin_Login_Form();
            this.Hide();
            form.Show();
            this.Close();
        }
    }
}
