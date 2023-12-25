namespace Minesweeper_Client
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.tbx_Account = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_Account = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbx_Password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Signup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lklbl_ForgotPass = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.LightCyan;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.LightCyan;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 20;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 1;
            this.kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.LightCyan;
            this.kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbx_Account
            // 
            this.tbx_Account.Location = new System.Drawing.Point(578, 263);
            this.tbx_Account.Name = "tbx_Account";
            this.tbx_Account.Size = new System.Drawing.Size(180, 30);
            this.tbx_Account.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbx_Account.StateCommon.Border.Rounding = 10;
            this.tbx_Account.StateCommon.Border.Width = 2;
            this.tbx_Account.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Account.TabIndex = 2;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = false;
            this.lbl_Account.Location = new System.Drawing.Point(578, 217);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Palette = this.kryptonPalette1;
            this.lbl_Account.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lbl_Account.Size = new System.Drawing.Size(115, 40);
            this.lbl_Account.TabIndex = 4;
            this.lbl_Account.Values.Text = "Account";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(578, 308);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.kryptonPalette1;
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(115, 40);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Password";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(578, 354);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.PasswordChar = '*';
            this.tbx_Password.Size = new System.Drawing.Size(180, 30);
            this.tbx_Password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbx_Password.StateCommon.Border.Rounding = 10;
            this.tbx_Password.StateCommon.Border.Width = 2;
            this.tbx_Password.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Password.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Minesweeper_Client.Properties.Resources.Icons8_Windows_8_Security_Password_2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(537, 354);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Minesweeper_Client.Properties.Resources.user_icon_150670;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(537, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Minesweeper_Client.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox2.Location = new System.Drawing.Point(537, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Minesweeper_Client.Properties.Resources.BackWall2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(663, 416);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Palette = this.kryptonPalette1;
            this.btn_Login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Login.Size = new System.Drawing.Size(95, 45);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Values.Text = "Log in";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Location = new System.Drawing.Point(537, 416);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Palette = this.kryptonPalette1;
            this.btn_Signup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Signup.Size = new System.Drawing.Size(95, 45);
            this.btn_Signup.TabIndex = 10;
            this.btn_Signup.Values.Text = "Sign up";
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // lklbl_ForgotPass
            // 
            this.lklbl_ForgotPass.Location = new System.Drawing.Point(566, 473);
            this.lklbl_ForgotPass.Name = "lklbl_ForgotPass";
            this.lklbl_ForgotPass.Size = new System.Drawing.Size(175, 21);
            this.lklbl_ForgotPass.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbl_ForgotPass.TabIndex = 11;
            this.lklbl_ForgotPass.Values.Text = "Forgot your password?";
            this.lklbl_ForgotPass.LinkClicked += new System.EventHandler(this.lklbl_ForgotPass_LinkClicked);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.lklbl_ForgotPass);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.tbx_Account);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "FormDangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbx_Account;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Account;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbx_Password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Signup;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lklbl_ForgotPass;
    }
}