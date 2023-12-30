namespace Minesweeper_Client
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_ID = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnIntermediate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExpert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCustom = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_AddFr = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_FindFr = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.FriendList = new System.Windows.Forms.ListView();
            this.FriendName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Player_Detail = new System.Windows.Forms.ListView();
            this.btn_Setting = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Quest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Attemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBeginner = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picB_Ranked = new System.Windows.Forms.PictureBox();
            this.pic_Renew = new System.Windows.Forms.PictureBox();
            this.picB_Chat = new System.Windows.Forms.PictureBox();
            this.picB_notification = new System.Windows.Forms.PictureBox();
            this.picbox_Ava = new System.Windows.Forms.PictureBox();
            this.picB_Signout = new System.Windows.Forms.PictureBox();
            this.picB_Setting = new System.Windows.Forms.PictureBox();
            this.picB_Quest = new System.Windows.Forms.PictureBox();
            this.FriendMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Ranked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Renew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Ava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Signout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Quest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(73, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 24);
            this.lblName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.TabIndex = 0;
            this.lblName.Values.Text = "NAMETEXT";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(73, 39);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(77, 24);
            this.lbl_ID.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Values.Text = "IDTEXT";
            // 
            // btnIntermediate
            // 
            this.btnIntermediate.Location = new System.Drawing.Point(140, 261);
            this.btnIntermediate.Name = "btnIntermediate";
            this.btnIntermediate.Size = new System.Drawing.Size(100, 50);
            this.btnIntermediate.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btnIntermediate.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnIntermediate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIntermediate.StateCommon.Border.Rounding = 15;
            this.btnIntermediate.StateCommon.Border.Width = 3;
            this.btnIntermediate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediate.TabIndex = 5;
            this.btnIntermediate.Values.Text = "Medium\r\n16x16";
            this.btnIntermediate.Click += new System.EventHandler(this.btnIntermediate_Click);
            // 
            // btnExpert
            // 
            this.btnExpert.Location = new System.Drawing.Point(264, 261);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(100, 50);
            this.btnExpert.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btnExpert.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnExpert.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExpert.StateCommon.Border.Rounding = 15;
            this.btnExpert.StateCommon.Border.Width = 3;
            this.btnExpert.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpert.TabIndex = 6;
            this.btnExpert.Values.Text = "Expert\r\n25x40\r\n";
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(388, 261);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(100, 50);
            this.btnCustom.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btnCustom.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btnCustom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustom.StateCommon.Border.Rounding = 15;
            this.btnCustom.StateCommon.Border.Width = 3;
            this.btnCustom.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.TabIndex = 7;
            this.btnCustom.Values.Text = "Custom\r\nMineBoard";
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.picbox_Ava);
            this.kryptonPanel1.Controls.Add(this.picB_Signout);
            this.kryptonPanel1.Controls.Add(this.lblName);
            this.kryptonPanel1.Controls.Add(this.lbl_ID);
            this.kryptonPanel1.Location = new System.Drawing.Point(8, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(204, 111);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // btn_AddFr
            // 
            this.btn_AddFr.Location = new System.Drawing.Point(144, 3);
            this.btn_AddFr.Name = "btn_AddFr";
            this.btn_AddFr.Size = new System.Drawing.Size(55, 45);
            this.btn_AddFr.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_AddFr.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left))));
            this.btn_AddFr.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_AddFr.StateCommon.Border.Rounding = 15;
            this.btn_AddFr.StateCommon.Border.Width = 3;
            this.btn_AddFr.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFr.TabIndex = 10;
            this.btn_AddFr.Values.Text = "Add";
            this.btn_AddFr.Click += new System.EventHandler(this.btn_AddFr_Click);
            // 
            // txt_FindFr
            // 
            this.txt_FindFr.Location = new System.Drawing.Point(4, 12);
            this.txt_FindFr.Name = "txt_FindFr";
            this.txt_FindFr.Size = new System.Drawing.Size(136, 27);
            this.txt_FindFr.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FindFr.TabIndex = 9;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.picB_notification);
            this.kryptonPanel2.Controls.Add(this.pic_Renew);
            this.kryptonPanel2.Controls.Add(this.picB_Chat);
            this.kryptonPanel2.Controls.Add(this.FriendList);
            this.kryptonPanel2.Controls.Add(this.btn_AddFr);
            this.kryptonPanel2.Controls.Add(this.txt_FindFr);
            this.kryptonPanel2.Location = new System.Drawing.Point(8, 118);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Palette = this.kryptonPalette1;
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel2.Size = new System.Drawing.Size(204, 327);
            this.kryptonPanel2.TabIndex = 9;
            // 
            // FriendList
            // 
            this.FriendList.BackColor = System.Drawing.Color.LightCyan;
            this.FriendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FriendName,
            this.FriendMode});
            this.FriendList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FriendList.HideSelection = false;
            this.FriendList.Location = new System.Drawing.Point(3, 93);
            this.FriendList.Name = "FriendList";
            this.FriendList.Size = new System.Drawing.Size(198, 231);
            this.FriendList.TabIndex = 4;
            this.FriendList.UseCompatibleStateImageBehavior = false;
            this.FriendList.View = System.Windows.Forms.View.Details;
            // 
            // FriendName
            // 
            this.FriendName.Text = "Friend";
            this.FriendName.Width = 105;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.Silver;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btn_Reset);
            this.kryptonPanel3.Controls.Add(this.picB_Setting);
            this.kryptonPanel3.Controls.Add(this.picB_Quest);
            this.kryptonPanel3.Controls.Add(this.Player_Detail);
            this.kryptonPanel3.Controls.Add(this.btn_Setting);
            this.kryptonPanel3.Controls.Add(this.btn_Quest);
            this.kryptonPanel3.Location = new System.Drawing.Point(215, 4);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Palette = this.kryptonPalette1;
            this.kryptonPanel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel3.Size = new System.Drawing.Size(581, 111);
            this.kryptonPanel3.TabIndex = 10;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(457, 31);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(67, 55);
            this.btn_Reset.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btn_Reset.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.btn_Reset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Reset.StateCommon.Border.Rounding = 15;
            this.btn_Reset.StateCommon.Border.Width = 3;
            this.btn_Reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Values.Text = "Reset";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Player_Detail
            // 
            this.Player_Detail.BackColor = System.Drawing.Color.LightCyan;
            this.Player_Detail.HideSelection = false;
            this.Player_Detail.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.Player_Detail.Location = new System.Drawing.Point(9, 14);
            this.Player_Detail.Name = "Player_Detail";
            this.Player_Detail.Size = new System.Drawing.Size(442, 81);
            this.Player_Detail.TabIndex = 5;
            this.Player_Detail.UseCompatibleStateImageBehavior = false;
            this.Player_Detail.View = System.Windows.Forms.View.List;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Location = new System.Drawing.Point(532, 50);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(45, 45);
            this.btn_Setting.StateCommon.Back.Image = global::Minesweeper_Client.Properties.Resources.gearpic;
            this.btn_Setting.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_Setting.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.btn_Setting.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Setting.StateCommon.Border.Rounding = 15;
            this.btn_Setting.StateCommon.Border.Width = 3;
            this.btn_Setting.TabIndex = 0;
            this.btn_Setting.Values.Image = global::Minesweeper_Client.Properties.Resources.gearpic;
            this.btn_Setting.Values.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_Setting.Values.Text = "";
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            this.btn_Setting.MouseEnter += new System.EventHandler(this.btn_Setting_MouseEnter);
            this.btn_Setting.MouseLeave += new System.EventHandler(this.btn_Setting_MouseLeave);
            // 
            // btn_Quest
            // 
            this.btn_Quest.Location = new System.Drawing.Point(530, 3);
            this.btn_Quest.Name = "btn_Quest";
            this.btn_Quest.Size = new System.Drawing.Size(45, 45);
            this.btn_Quest.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btn_Quest.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
            this.btn_Quest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Quest.StateCommon.Border.Rounding = 15;
            this.btn_Quest.StateCommon.Border.Width = 3;
            this.btn_Quest.TabIndex = 3;
            this.btn_Quest.Values.Text = "";
            this.btn_Quest.Click += new System.EventHandler(this.btn_Quest_Click);
            this.btn_Quest.MouseEnter += new System.EventHandler(this.btn_Quest_MouseEnter);
            this.btn_Quest.MouseLeave += new System.EventHandler(this.btn_Quest_MouseLeave);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.picB_Ranked);
            this.kryptonPanel4.Controls.Add(this.listView1);
            this.kryptonPanel4.Controls.Add(this.btnBeginner);
            this.kryptonPanel4.Controls.Add(this.btnExpert);
            this.kryptonPanel4.Controls.Add(this.btnCustom);
            this.kryptonPanel4.Controls.Add(this.btnIntermediate);
            this.kryptonPanel4.Location = new System.Drawing.Point(215, 118);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Palette = this.kryptonPalette1;
            this.kryptonPanel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel4.Size = new System.Drawing.Size(581, 327);
            this.kryptonPanel4.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightCyan;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Attemp,
            this.Mode,
            this.Score,
            this.Time});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 228);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Attemp
            // 
            this.Attemp.Text = "Attempt";
            this.Attemp.Width = 80;
            // 
            // Mode
            // 
            this.Mode.Text = "Mode";
            this.Mode.Width = 130;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 100;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 124;
            // 
            // btnBeginner
            // 
            this.btnBeginner.Location = new System.Drawing.Point(9, 261);
            this.btnBeginner.Name = "btnBeginner";
            this.btnBeginner.Size = new System.Drawing.Size(100, 50);
            this.btnBeginner.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.btnBeginner.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBeginner.StateCommon.Border.Rounding = 15;
            this.btnBeginner.StateCommon.Border.Width = 3;
            this.btnBeginner.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginner.TabIndex = 9;
            this.btnBeginner.Values.Text = "Beginner\r\n10x10";
            this.btnBeginner.Click += new System.EventHandler(this.btnBeginner_Click);
            // 
            // picB_Ranked
            // 
            this.picB_Ranked.BackColor = System.Drawing.Color.Transparent;
            this.picB_Ranked.Image = global::Minesweeper_Client.Properties.Resources.rankedPic;
            this.picB_Ranked.Location = new System.Drawing.Point(508, 261);
            this.picB_Ranked.Name = "picB_Ranked";
            this.picB_Ranked.Size = new System.Drawing.Size(67, 50);
            this.picB_Ranked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Ranked.TabIndex = 7;
            this.picB_Ranked.TabStop = false;
            this.picB_Ranked.Click += new System.EventHandler(this.picB_Ranked_Click);
            this.picB_Ranked.MouseEnter += new System.EventHandler(this.picB_Ranked_MouseEnter);
            this.picB_Ranked.MouseLeave += new System.EventHandler(this.picB_Ranked_MouseLeave);
            // 
            // pic_Renew
            // 
            this.pic_Renew.BackColor = System.Drawing.Color.Transparent;
            this.pic_Renew.Image = global::Minesweeper_Client.Properties.Resources.reload_icon_16912;
            this.pic_Renew.Location = new System.Drawing.Point(156, 52);
            this.pic_Renew.Name = "pic_Renew";
            this.pic_Renew.Size = new System.Drawing.Size(45, 41);
            this.pic_Renew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Renew.TabIndex = 9;
            this.pic_Renew.TabStop = false;
            this.pic_Renew.Click += new System.EventHandler(this.pic_Renew_Click);
            // 
            // picB_Chat
            // 
            this.picB_Chat.BackColor = System.Drawing.Color.Transparent;
            this.picB_Chat.Image = global::Minesweeper_Client.Properties.Resources.chatPic;
            this.picB_Chat.Location = new System.Drawing.Point(4, 50);
            this.picB_Chat.Name = "picB_Chat";
            this.picB_Chat.Size = new System.Drawing.Size(43, 43);
            this.picB_Chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Chat.TabIndex = 7;
            this.picB_Chat.TabStop = false;
            this.picB_Chat.Click += new System.EventHandler(this.picB_Chat_Click);
            this.picB_Chat.MouseEnter += new System.EventHandler(this.picB_Chat_MouseEnter);
            this.picB_Chat.MouseLeave += new System.EventHandler(this.picB_Chat_MouseLeave);
            // 
            // picB_notification
            // 
            this.picB_notification.BackColor = System.Drawing.Color.Transparent;
            this.picB_notification.Image = global::Minesweeper_Client.Properties.Resources.bell_pic;
            this.picB_notification.Location = new System.Drawing.Point(73, 52);
            this.picB_notification.Name = "picB_notification";
            this.picB_notification.Size = new System.Drawing.Size(44, 41);
            this.picB_notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_notification.TabIndex = 8;
            this.picB_notification.TabStop = false;
            this.picB_notification.Click += new System.EventHandler(this.picB_notification_Click);
            this.picB_notification.MouseEnter += new System.EventHandler(this.picB_notification_MouseEnter);
            this.picB_notification.MouseLeave += new System.EventHandler(this.picB_notification_MouseLeave);
            // 
            // picbox_Ava
            // 
            this.picbox_Ava.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picbox_Ava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_Ava.BackgroundImage")));
            this.picbox_Ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_Ava.Location = new System.Drawing.Point(4, 3);
            this.picbox_Ava.Name = "picbox_Ava";
            this.picbox_Ava.Size = new System.Drawing.Size(63, 62);
            this.picbox_Ava.TabIndex = 1;
            this.picbox_Ava.TabStop = false;
            // 
            // picB_Signout
            // 
            this.picB_Signout.BackColor = System.Drawing.Color.Transparent;
            this.picB_Signout.Image = global::Minesweeper_Client.Properties.Resources.signout_icon;
            this.picB_Signout.Location = new System.Drawing.Point(156, 61);
            this.picB_Signout.Name = "picB_Signout";
            this.picB_Signout.Size = new System.Drawing.Size(45, 47);
            this.picB_Signout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Signout.TabIndex = 6;
            this.picB_Signout.TabStop = false;
            this.picB_Signout.Click += new System.EventHandler(this.picB_Signout_Click);
            this.picB_Signout.MouseEnter += new System.EventHandler(this.picB_MouseEnter);
            this.picB_Signout.MouseLeave += new System.EventHandler(this.picB_MouseLeave);
            // 
            // picB_Setting
            // 
            this.picB_Setting.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picB_Setting.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picB_Setting.BackgroundImage = global::Minesweeper_Client.Properties.Resources.gearpic;
            this.picB_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_Setting.Enabled = false;
            this.picB_Setting.Location = new System.Drawing.Point(541, 61);
            this.picB_Setting.Name = "picB_Setting";
            this.picB_Setting.Size = new System.Drawing.Size(25, 25);
            this.picB_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Setting.TabIndex = 2;
            this.picB_Setting.TabStop = false;
            // 
            // picB_Quest
            // 
            this.picB_Quest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.picB_Quest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picB_Quest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_Quest.Enabled = false;
            this.picB_Quest.Image = global::Minesweeper_Client.Properties.Resources.questpic;
            this.picB_Quest.Location = new System.Drawing.Point(541, 14);
            this.picB_Quest.Name = "picB_Quest";
            this.picB_Quest.Size = new System.Drawing.Size(25, 25);
            this.picB_Quest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Quest.TabIndex = 4;
            this.picB_Quest.TabStop = false;
            this.picB_Quest.Click += new System.EventHandler(this.btn_Quest_Click);
            // 
            // FriendMode
            // 
            this.FriendMode.Text = "Mode";
            this.FriendMode.Width = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Ranked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Renew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Ava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Signout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Quest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private System.Windows.Forms.PictureBox picbox_Ava;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIntermediate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExpert;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCustom;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Setting;
        private System.Windows.Forms.PictureBox picB_Quest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Quest;
        private System.Windows.Forms.PictureBox picB_Setting;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBeginner;
        private System.Windows.Forms.ListView FriendList;
        private System.Windows.Forms.ColumnHeader FriendName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Attemp;
        private System.Windows.Forms.ColumnHeader Mode;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ListView Player_Detail;
        private System.Windows.Forms.PictureBox picB_Signout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Reset;
        private System.Windows.Forms.PictureBox picB_Ranked;
        private System.Windows.Forms.PictureBox picB_notification;
        private System.Windows.Forms.PictureBox picB_Chat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddFr;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_FindFr;
        private System.Windows.Forms.PictureBox pic_Renew;
        private System.Windows.Forms.ColumnHeader FriendMode;
    }
}
