namespace Minesweeper_Client
{
    partial class Form_Setting
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
            this.btn_Changepass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_ResetName = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkbx_Sound = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Changepass
            // 
            this.btn_Changepass.Location = new System.Drawing.Point(59, 122);
            this.btn_Changepass.Name = "btn_Changepass";
            this.btn_Changepass.Palette = this.kryptonPalette1;
            this.btn_Changepass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Changepass.Size = new System.Drawing.Size(220, 45);
            this.btn_Changepass.TabIndex = 0;
            this.btn_Changepass.Values.Text = "Change Password";
            this.btn_Changepass.Click += new System.EventHandler(this.btn_Changepass_Click);
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
            // btn_ResetName
            // 
            this.btn_ResetName.Location = new System.Drawing.Point(59, 199);
            this.btn_ResetName.Name = "btn_ResetName";
            this.btn_ResetName.Palette = this.kryptonPalette1;
            this.btn_ResetName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_ResetName.Size = new System.Drawing.Size(220, 45);
            this.btn_ResetName.TabIndex = 1;
            this.btn_ResetName.Values.Text = "Change Name";
            this.btn_ResetName.Click += new System.EventHandler(this.btn_ResetName_Click);
            // 
            // chkbx_Sound
            // 
            this.chkbx_Sound.AutoSize = false;
            this.chkbx_Sound.Checked = true;
            this.chkbx_Sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_Sound.Location = new System.Drawing.Point(12, 18);
            this.chkbx_Sound.Name = "chkbx_Sound";
            this.chkbx_Sound.Size = new System.Drawing.Size(120, 25);
            this.chkbx_Sound.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_Sound.TabIndex = 4;
            this.chkbx_Sound.Values.Text = "Sounds";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.chkbx_Sound);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(308, 70);
            this.kryptonPanel1.TabIndex = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(59, 274);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Palette = this.kryptonPalette1;
            this.btn_Cancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Cancel.Size = new System.Drawing.Size(220, 45);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 353);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btn_Changepass);
            this.Controls.Add(this.btn_ResetName);
            this.Name = "Form_Setting";
            this.Text = "Form_Setting";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Changepass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ResetName;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkbx_Sound;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
    }
}