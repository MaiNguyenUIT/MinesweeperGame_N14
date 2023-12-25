namespace Minesweeper_Client
{
    partial class Form_PasswordChanged
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
            this.txt_MK = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_NewPass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_ReType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_OldPass = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Newpass = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_NewpassConfirm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Confirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_tb = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MK
            // 
            this.txt_MK.AcceptsReturn = true;
            this.txt_MK.Location = new System.Drawing.Point(407, 114);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(250, 33);
            this.txt_MK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_MK.StateCommon.Border.Rounding = 10;
            this.txt_MK.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.TabIndex = 0;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.AcceptsReturn = true;
            this.txt_NewPass.Location = new System.Drawing.Point(407, 219);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.PasswordChar = '*';
            this.txt_NewPass.Size = new System.Drawing.Size(250, 33);
            this.txt_NewPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_NewPass.StateCommon.Border.Rounding = 10;
            this.txt_NewPass.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.TabIndex = 1;
            // 
            // txt_ReType
            // 
            this.txt_ReType.AcceptsReturn = true;
            this.txt_ReType.Location = new System.Drawing.Point(407, 334);
            this.txt_ReType.Name = "txt_ReType";
            this.txt_ReType.PasswordChar = '*';
            this.txt_ReType.Size = new System.Drawing.Size(250, 33);
            this.txt_ReType.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_ReType.StateCommon.Border.Rounding = 10;
            this.txt_ReType.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReType.TabIndex = 2;
            // 
            // lbl_OldPass
            // 
            this.lbl_OldPass.AutoSize = false;
            this.lbl_OldPass.Location = new System.Drawing.Point(407, 68);
            this.lbl_OldPass.Name = "lbl_OldPass";
            this.lbl_OldPass.Size = new System.Drawing.Size(230, 40);
            this.lbl_OldPass.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldPass.TabIndex = 3;
            this.lbl_OldPass.Values.Text = "Last Password";
            // 
            // lbl_Newpass
            // 
            this.lbl_Newpass.AutoSize = false;
            this.lbl_Newpass.Location = new System.Drawing.Point(407, 173);
            this.lbl_Newpass.Name = "lbl_Newpass";
            this.lbl_Newpass.Size = new System.Drawing.Size(230, 40);
            this.lbl_Newpass.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Newpass.TabIndex = 4;
            this.lbl_Newpass.Values.Text = "New Password";
            // 
            // lbl_NewpassConfirm
            // 
            this.lbl_NewpassConfirm.AutoSize = false;
            this.lbl_NewpassConfirm.Location = new System.Drawing.Point(407, 288);
            this.lbl_NewpassConfirm.Name = "lbl_NewpassConfirm";
            this.lbl_NewpassConfirm.Size = new System.Drawing.Size(230, 40);
            this.lbl_NewpassConfirm.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewpassConfirm.TabIndex = 5;
            this.lbl_NewpassConfirm.Values.Text = "Retype your new pass";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(407, 389);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Palette = this.kryptonPalette1;
            this.btn_Confirm.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Confirm.Size = new System.Drawing.Size(100, 45);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Values.Text = "Confirm";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(557, 389);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Palette = this.kryptonPalette1;
            this.btn_Cancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Cancel.Size = new System.Drawing.Size(100, 45);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Location = new System.Drawing.Point(-3, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(300, 525);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::Minesweeper_Client.Properties.Resources.passchangedgif;
            this.pictureBox1.Location = new System.Drawing.Point(3, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_tb
            // 
            this.label_tb.Location = new System.Drawing.Point(407, 441);
            this.label_tb.Name = "label_tb";
            this.label_tb.Size = new System.Drawing.Size(6, 2);
            this.label_tb.TabIndex = 9;
            this.label_tb.Values.Text = "";
            // 
            // Form_PasswordChanged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_NewpassConfirm);
            this.Controls.Add(this.lbl_Newpass);
            this.Controls.Add(this.lbl_OldPass);
            this.Controls.Add(this.txt_ReType);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.txt_MK);
            this.Name = "Form_PasswordChanged";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 2;
            this.Text = "Form_PasswordChanged";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_PasswordChanged_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_MK;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_NewPass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ReType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_OldPass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Newpass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_NewpassConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confirm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label_tb;
    }
}