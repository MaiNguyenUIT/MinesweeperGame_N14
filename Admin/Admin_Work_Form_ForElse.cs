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

        private void pLAYER_FRIENDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pLAYER_FRIENDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseOfMineSweeperDataSet);

        }

        private void Admin_Work_Form_ForElse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOfMineSweeperDataSet.PLAYER_SCORE' table. You can move, or remove it, as needed.
            this.pLAYER_SCORETableAdapter.Fill(this.databaseOfMineSweeperDataSet.PLAYER_SCORE);
            // TODO: This line of code loads data into the 'databaseOfMineSweeperDataSet.PLAYER_FRIENDS' table. You can move, or remove it, as needed.
            this.pLAYER_FRIENDSTableAdapter.Fill(this.databaseOfMineSweeperDataSet.PLAYER_FRIENDS);

        }

        private void btbNext_Click(object sender, EventArgs e)
        {
            Admin_MainWork_Form form = new Admin_MainWork_Form();
            this.Hide();
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
