namespace Minesweeper_Client
{
    partial class Form_Ranked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ranked));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Expert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Intermediate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Beginner = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listView_Expert = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Mediate = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Beginner = new System.Windows.Forms.ListView();
            this.columnTop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.picbox_Ava = new System.Windows.Forms.PictureBox();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Exit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listView_UserMaxScore = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Ava)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_Expert);
            this.kryptonPanel1.Controls.Add(this.btn_Intermediate);
            this.kryptonPanel1.Controls.Add(this.btn_Beginner);
            this.kryptonPanel1.Controls.Add(this.listView_Expert);
            this.kryptonPanel1.Controls.Add(this.listView_Mediate);
            this.kryptonPanel1.Controls.Add(this.listView_Beginner);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 118);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(775, 334);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btn_Expert
            // 
            this.btn_Expert.Location = new System.Drawing.Point(564, 7);
            this.btn_Expert.Name = "btn_Expert";
            this.btn_Expert.Size = new System.Drawing.Size(110, 30);
            this.btn_Expert.TabIndex = 10;
            this.btn_Expert.Values.Text = "Expert";
            this.btn_Expert.Click += new System.EventHandler(this.btn_Expert_Click);
            // 
            // btn_Intermediate
            // 
            this.btn_Intermediate.Location = new System.Drawing.Point(304, 7);
            this.btn_Intermediate.Name = "btn_Intermediate";
            this.btn_Intermediate.Size = new System.Drawing.Size(147, 30);
            this.btn_Intermediate.TabIndex = 9;
            this.btn_Intermediate.Values.Text = "Intermediate";
            this.btn_Intermediate.Click += new System.EventHandler(this.btn_Intermediate_Click);
            // 
            // btn_Beginner
            // 
            this.btn_Beginner.Location = new System.Drawing.Point(53, 7);
            this.btn_Beginner.Name = "btn_Beginner";
            this.btn_Beginner.Size = new System.Drawing.Size(110, 30);
            this.btn_Beginner.TabIndex = 8;
            this.btn_Beginner.Values.Text = "Beginner";
            this.btn_Beginner.Click += new System.EventHandler(this.btn_Beginner_Click);
            // 
            // listView_Expert
            // 
            this.listView_Expert.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Expert.HideSelection = false;
            this.listView_Expert.Location = new System.Drawing.Point(520, 36);
            this.listView_Expert.Name = "listView_Expert";
            this.listView_Expert.Size = new System.Drawing.Size(250, 295);
            this.listView_Expert.TabIndex = 7;
            this.listView_Expert.UseCompatibleStateImageBehavior = false;
            this.listView_Expert.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Top";
            this.columnHeader4.Width = 35;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Score";
            // 
            // listView_Mediate
            // 
            this.listView_Mediate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Mediate.HideSelection = false;
            this.listView_Mediate.Location = new System.Drawing.Point(259, 36);
            this.listView_Mediate.Name = "listView_Mediate";
            this.listView_Mediate.Size = new System.Drawing.Size(250, 295);
            this.listView_Mediate.TabIndex = 6;
            this.listView_Mediate.UseCompatibleStateImageBehavior = false;
            this.listView_Mediate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Top";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Score";
            // 
            // listView_Beginner
            // 
            this.listView_Beginner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTop,
            this.columnName,
            this.columnScore});
            this.listView_Beginner.HideSelection = false;
            this.listView_Beginner.Location = new System.Drawing.Point(3, 36);
            this.listView_Beginner.Name = "listView_Beginner";
            this.listView_Beginner.Size = new System.Drawing.Size(250, 295);
            this.listView_Beginner.TabIndex = 5;
            this.listView_Beginner.UseCompatibleStateImageBehavior = false;
            this.listView_Beginner.View = System.Windows.Forms.View.Details;
            // 
            // columnTop
            // 
            this.columnTop.Text = "Top";
            this.columnTop.Width = 35;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 88;
            // 
            // columnScore
            // 
            this.columnScore.Text = "Score";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.picbox_Ava);
            this.kryptonPanel2.Controls.Add(this.lblName);
            this.kryptonPanel2.Controls.Add(this.lbl_ID);
            this.kryptonPanel2.Controls.Add(this.btn_Exit);
            this.kryptonPanel2.Controls.Add(this.btn_reset);
            this.kryptonPanel2.Controls.Add(this.listView_UserMaxScore);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(775, 110);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // picbox_Ava
            // 
            this.picbox_Ava.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picbox_Ava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_Ava.BackgroundImage")));
            this.picbox_Ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_Ava.Location = new System.Drawing.Point(3, 3);
            this.picbox_Ava.Name = "picbox_Ava";
            this.picbox_Ava.Size = new System.Drawing.Size(44, 39);
            this.picbox_Ava.TabIndex = 11;
            this.picbox_Ava.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(53, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 19);
            this.lblName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.TabIndex = 10;
            this.lblName.Values.Text = "NAMETEXT";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(53, 28);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(60, 19);
            this.lbl_ID.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.TabIndex = 9;
            this.lbl_ID.Values.Text = "IDTEXT";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(680, 54);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 45);
            this.btn_Exit.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_Exit.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.btn_Exit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Exit.StateCommon.Border.Rounding = 15;
            this.btn_Exit.StateCommon.Border.Width = 3;
            this.btn_Exit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Values.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(680, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 45);
            this.btn_reset.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_reset.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.btn_reset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_reset.StateCommon.Border.Rounding = 15;
            this.btn_reset.StateCommon.Border.Width = 3;
            this.btn_reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Values.Text = "Reset";
            // 
            // listView_UserMaxScore
            // 
            this.listView_UserMaxScore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listView_UserMaxScore.HideSelection = false;
            this.listView_UserMaxScore.Location = new System.Drawing.Point(182, 3);
            this.listView_UserMaxScore.Name = "listView_UserMaxScore";
            this.listView_UserMaxScore.Size = new System.Drawing.Size(458, 104);
            this.listView_UserMaxScore.TabIndex = 6;
            this.listView_UserMaxScore.UseCompatibleStateImageBehavior = false;
            // 
            // Form_Ranked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form_Ranked";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 2;
            this.Text = "Form_Ranked";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Ava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.ListView listView_UserMaxScore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Exit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_reset;
        private System.Windows.Forms.ListView listView_Beginner;
        private System.Windows.Forms.ColumnHeader columnTop;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnScore;
        private System.Windows.Forms.ListView listView_Expert;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView_Mediate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private System.Windows.Forms.PictureBox picbox_Ava;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Expert;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Intermediate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Beginner;
    }
}