using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.DatabaseOfMineSweeperDataSetTableAdapters;
using ComponentFactory.Krypton.Toolkit;

namespace Admin
{
    public partial class Admin_Login_Form : KryptonForm
    {
        public Admin_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
        }
        bool CheckForLogin(string acc, string pass)
        {
            
            
            return false;
        }

    }
}
