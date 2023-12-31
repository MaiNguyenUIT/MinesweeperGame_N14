﻿namespace Minesweeper_Client
{
    partial class Form_Information
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ingame = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Sex = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Gmail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_Ingame = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_Name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_Mail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_Sex = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lb_Sex);
            this.kryptonPanel1.Controls.Add(this.lb_Mail);
            this.kryptonPanel1.Controls.Add(this.lb_Name);
            this.kryptonPanel1.Controls.Add(this.lb_Ingame);
            this.kryptonPanel1.Controls.Add(this.lb_ID);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.lbl_ingame);
            this.kryptonPanel1.Controls.Add(this.lbl_Sex);
            this.kryptonPanel1.Controls.Add(this.lbl_Gmail);
            this.kryptonPanel1.Controls.Add(this.lbl_Name);
            this.kryptonPanel1.Controls.Add(this.lbl_ID);
            this.kryptonPanel1.Location = new System.Drawing.Point(204, 1);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(327, 469);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Minesweeper_Client.Properties.Resources.user_icon_150670;
            this.pictureBox1.Location = new System.Drawing.Point(89, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ingame
            // 
            this.lbl_ingame.Location = new System.Drawing.Point(7, 208);
            this.lbl_ingame.Name = "lbl_ingame";
            this.lbl_ingame.Size = new System.Drawing.Size(78, 24);
            this.lbl_ingame.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingame.TabIndex = 4;
            this.lbl_ingame.Values.Text = "Ingame: ";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.Location = new System.Drawing.Point(36, 381);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(49, 24);
            this.lbl_Sex.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sex.TabIndex = 3;
            this.lbl_Sex.Values.Text = "Sex: ";
            // 
            // lbl_Gmail
            // 
            this.lbl_Gmail.Location = new System.Drawing.Point(20, 327);
            this.lbl_Gmail.Name = "lbl_Gmail";
            this.lbl_Gmail.Size = new System.Drawing.Size(65, 24);
            this.lbl_Gmail.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gmail.TabIndex = 2;
            this.lbl_Gmail.Values.Text = "Gmail: ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Location = new System.Drawing.Point(20, 268);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 24);
            this.lbl_Name.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Values.Text = "Name: ";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(49, 154);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(36, 24);
            this.lbl_ID.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Values.Text = "ID: ";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.pictureBox2);
            this.kryptonPanel2.Location = new System.Drawing.Point(2, 1);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(203, 469);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.SlateGray;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Minesweeper_Client.Properties.Resources.gif_Signup;
            this.pictureBox2.Location = new System.Drawing.Point(3, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lb_ID
            // 
            this.lb_ID.Location = new System.Drawing.Point(106, 154);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(109, 24);
            this.lb_ID.TabIndex = 11;
            this.lb_ID.Values.Text = "kryptonLabel1";
            // 
            // lb_Ingame
            // 
            this.lb_Ingame.Location = new System.Drawing.Point(106, 208);
            this.lb_Ingame.Name = "lb_Ingame";
            this.lb_Ingame.Size = new System.Drawing.Size(109, 24);
            this.lb_Ingame.TabIndex = 12;
            this.lb_Ingame.Values.Text = "kryptonLabel1";
            // 
            // lb_Name
            // 
            this.lb_Name.Location = new System.Drawing.Point(106, 268);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(109, 24);
            this.lb_Name.TabIndex = 13;
            this.lb_Name.Values.Text = "kryptonLabel1";
            // 
            // lb_Mail
            // 
            this.lb_Mail.Location = new System.Drawing.Point(106, 327);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(109, 24);
            this.lb_Mail.TabIndex = 14;
            this.lb_Mail.Values.Text = "kryptonLabel1";
            // 
            // lb_Sex
            // 
            this.lb_Sex.Location = new System.Drawing.Point(106, 381);
            this.lb_Sex.Name = "lb_Sex";
            this.lb_Sex.Size = new System.Drawing.Size(109, 24);
            this.lb_Sex.TabIndex = 15;
            this.lb_Sex.Values.Text = "kryptonLabel1";
            // 
            // Form_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 472);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form_Information";
            this.Text = "Form_Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ingame;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Sex;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Gmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_Sex;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_Mail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_Ingame;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_ID;
    }
}