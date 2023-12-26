using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace Minesweeper_Client
{
    public partial class Form_Setting : KryptonForm
    {
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        

        private void btn_Changepass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_PasswordChanged form_PasswordChanged = new Form_PasswordChanged();
            form_PasswordChanged.ShowDialog();
        }

        
    }
}
