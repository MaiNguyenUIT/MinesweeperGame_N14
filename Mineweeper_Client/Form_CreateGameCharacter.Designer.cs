namespace Minesweeper_Client
{
    partial class Form_CreateGameCharacter
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
            this.lbl_NameofCharacter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_ingame = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Confirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label_ig = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Random = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NameofCharacter
            // 
            this.lbl_NameofCharacter.AutoSize = false;
            this.lbl_NameofCharacter.Location = new System.Drawing.Point(36, 37);
            this.lbl_NameofCharacter.Name = "lbl_NameofCharacter";
            this.lbl_NameofCharacter.Size = new System.Drawing.Size(220, 40);
            this.lbl_NameofCharacter.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameofCharacter.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameofCharacter.TabIndex = 0;
            this.lbl_NameofCharacter.Values.Text = "Name of your character";
            // 
            // txt_ingame
            // 
            this.txt_ingame.Location = new System.Drawing.Point(24, 71);
            this.txt_ingame.Name = "txt_ingame";
            this.txt_ingame.Size = new System.Drawing.Size(220, 35);
            this.txt_ingame.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_ingame.StateCommon.Border.Rounding = 10;
            this.txt_ingame.StateCommon.Border.Width = 2;
            this.txt_ingame.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ingame.TabIndex = 1;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(149, 142);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(95, 40);
            this.btn_Confirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Confirm.StateCommon.Border.Rounding = 15;
            this.btn_Confirm.StateCommon.Border.Width = 3;
            this.btn_Confirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.TabIndex = 2;
            this.btn_Confirm.Values.Text = "Confirm";
            this.btn_Confirm.Click += new System.EventHandler(this.tao_ingame_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label_ig);
            this.kryptonPanel1.Controls.Add(this.txt_ingame);
            this.kryptonPanel1.Controls.Add(this.btn_Random);
            this.kryptonPanel1.Controls.Add(this.btn_Confirm);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(258, 229);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // label_ig
            // 
            this.label_ig.Location = new System.Drawing.Point(24, 189);
            this.label_ig.Name = "label_ig";
            this.label_ig.Size = new System.Drawing.Size(6, 2);
            this.label_ig.TabIndex = 4;
            this.label_ig.Values.Text = "";
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(24, 142);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(100, 40);
            this.btn_Random.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Random.StateCommon.Border.Rounding = 15;
            this.btn_Random.StateCommon.Border.Width = 3;
            this.btn_Random.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Random.TabIndex = 3;
            this.btn_Random.Values.Text = "Random";
            this.btn_Random.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form_CreateGameCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lbl_NameofCharacter);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form_CreateGameCharacter";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 1;
            this.Text = "Form_CreateGameCharacter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQMK_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_NameofCharacter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_ingame;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confirm;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Random;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label_ig;
    }
}
