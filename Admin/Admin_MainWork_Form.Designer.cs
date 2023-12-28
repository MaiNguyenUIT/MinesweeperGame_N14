namespace Admin
{
    partial class Admin_MainWork_Form
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label taikhoanLabel;
            System.Windows.Forms.Label matkhauLabel;
            System.Windows.Forms.Label gmailLabel;
            System.Windows.Forms.Label hotenLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label ingameLabel;
            System.Windows.Forms.Label modeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_MainWork_Form));
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblName_Of_Work_Form1 = new System.Windows.Forms.Label();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dOAN_LTTQDataSet = new Admin.DOAN_LTTQDataSet();
            this.user_InfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_InfTableAdapter = new Admin.DOAN_LTTQDataSetTableAdapters.User_InfTableAdapter();
            this.tableAdapterManager = new Admin.DOAN_LTTQDataSetTableAdapters.TableAdapterManager();
            this.user_InfBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.user_InfBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_InfDataGridView = new System.Windows.Forms.DataGridView();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.taikhoanTextBox = new System.Windows.Forms.TextBox();
            this.matkhauTextBox = new System.Windows.Forms.TextBox();
            this.gmailTextBox = new System.Windows.Forms.TextBox();
            this.hotenTextBox = new System.Windows.Forms.TextBox();
            this.gioitinhTextBox = new System.Windows.Forms.TextBox();
            this.ingameTextBox = new System.Windows.Forms.TextBox();
            this.modeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            taikhoanLabel = new System.Windows.Forms.Label();
            matkhauLabel = new System.Windows.Forms.Label();
            gmailLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            ingameLabel = new System.Windows.Forms.Label();
            modeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_LTTQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_InfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_InfBindingNavigator)).BeginInit();
            this.user_InfBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_InfDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(22, 307);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 17;
            iDLabel.Text = "ID:";
            // 
            // taikhoanLabel
            // 
            taikhoanLabel.AutoSize = true;
            taikhoanLabel.Location = new System.Drawing.Point(175, 307);
            taikhoanLabel.Name = "taikhoanLabel";
            taikhoanLabel.Size = new System.Drawing.Size(67, 16);
            taikhoanLabel.TabIndex = 18;
            taikhoanLabel.Text = "Taikhoan:";
            // 
            // matkhauLabel
            // 
            matkhauLabel.AutoSize = true;
            matkhauLabel.Location = new System.Drawing.Point(436, 310);
            matkhauLabel.Name = "matkhauLabel";
            matkhauLabel.Size = new System.Drawing.Size(61, 16);
            matkhauLabel.TabIndex = 19;
            matkhauLabel.Text = "Matkhau:";
            // 
            // gmailLabel
            // 
            gmailLabel.AutoSize = true;
            gmailLabel.Location = new System.Drawing.Point(14, 347);
            gmailLabel.Name = "gmailLabel";
            gmailLabel.Size = new System.Drawing.Size(45, 16);
            gmailLabel.TabIndex = 20;
            gmailLabel.Text = "Gmail:";
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(242, 350);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(46, 16);
            hotenLabel.TabIndex = 21;
            hotenLabel.Text = "Hoten:";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(680, 353);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(54, 16);
            gioitinhLabel.TabIndex = 22;
            gioitinhLabel.Text = "Gioitinh:";
            // 
            // ingameLabel
            // 
            ingameLabel.AutoSize = true;
            ingameLabel.Location = new System.Drawing.Point(458, 353);
            ingameLabel.Name = "ingameLabel";
            ingameLabel.Size = new System.Drawing.Size(55, 16);
            ingameLabel.TabIndex = 23;
            ingameLabel.Text = "ingame:";
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Location = new System.Drawing.Point(698, 317);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new System.Drawing.Size(45, 16);
            modeLabel.TabIndex = 24;
            modeLabel.Text = "mode:";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AccessibleDescription = "btnEdit";
            this.kryptonButton1.Location = new System.Drawing.Point(553, 393);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(95, 45);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "Edit";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(693, 393);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 45);
            this.btnNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.Rounding = 15;
            this.btnNext.StateCommon.Border.Width = 1;
            this.btnNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.TabIndex = 5;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblName_Of_Work_Form1
            // 
            this.lblName_Of_Work_Form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_Of_Work_Form1.ForeColor = System.Drawing.Color.DimGray;
            this.lblName_Of_Work_Form1.Location = new System.Drawing.Point(296, 30);
            this.lblName_Of_Work_Form1.Name = "lblName_Of_Work_Form1";
            this.lblName_Of_Work_Form1.Size = new System.Drawing.Size(143, 27);
            this.lblName_Of_Work_Form1.TabIndex = 6;
            this.lblName_Of_Work_Form1.Text = "Player Detail";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(40, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 45);
            this.btnExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateCommon.Border.Rounding = 15;
            this.btnExit.StateCommon.Border.Width = 1;
            this.btnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TabIndex = 16;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dOAN_LTTQDataSet
            // 
            this.dOAN_LTTQDataSet.DataSetName = "DOAN_LTTQDataSet";
            this.dOAN_LTTQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_InfBindingSource
            // 
            this.user_InfBindingSource.DataMember = "User_Inf";
            this.user_InfBindingSource.DataSource = this.dOAN_LTTQDataSet;
            // 
            // user_InfTableAdapter
            // 
            this.user_InfTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Admin_InfTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Admin.DOAN_LTTQDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_InfTableAdapter = this.user_InfTableAdapter;
            this.tableAdapterManager.User_ScoreTableAdapter = null;
            // 
            // user_InfBindingNavigator
            // 
            this.user_InfBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user_InfBindingNavigator.BindingSource = this.user_InfBindingSource;
            this.user_InfBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user_InfBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_InfBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_InfBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.user_InfBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.user_InfBindingNavigatorSaveItem});
            this.user_InfBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user_InfBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.user_InfBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.user_InfBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.user_InfBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.user_InfBindingNavigator.Name = "user_InfBindingNavigator";
            this.user_InfBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user_InfBindingNavigator.Size = new System.Drawing.Size(827, 27);
            this.user_InfBindingNavigator.TabIndex = 17;
            this.user_InfBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // user_InfBindingNavigatorSaveItem
            // 
            this.user_InfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_InfBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_InfBindingNavigatorSaveItem.Image")));
            this.user_InfBindingNavigatorSaveItem.Name = "user_InfBindingNavigatorSaveItem";
            this.user_InfBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.user_InfBindingNavigatorSaveItem.Text = "Save Data";
            this.user_InfBindingNavigatorSaveItem.Click += new System.EventHandler(this.user_InfBindingNavigatorSaveItem_Click);
            // 
            // user_InfDataGridView
            // 
            this.user_InfDataGridView.AutoGenerateColumns = false;
            this.user_InfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_InfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.user_InfDataGridView.DataSource = this.user_InfBindingSource;
            this.user_InfDataGridView.Location = new System.Drawing.Point(12, 73);
            this.user_InfDataGridView.Name = "user_InfDataGridView";
            this.user_InfDataGridView.RowHeadersWidth = 51;
            this.user_InfDataGridView.RowTemplate.Height = 24;
            this.user_InfDataGridView.Size = new System.Drawing.Size(804, 221);
            this.user_InfDataGridView.TabIndex = 17;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(51, 304);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(118, 22);
            this.iDTextBox.TabIndex = 18;
            // 
            // taikhoanTextBox
            // 
            this.taikhoanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "Taikhoan", true));
            this.taikhoanTextBox.Location = new System.Drawing.Point(248, 304);
            this.taikhoanTextBox.Name = "taikhoanTextBox";
            this.taikhoanTextBox.Size = new System.Drawing.Size(182, 22);
            this.taikhoanTextBox.TabIndex = 19;
            // 
            // matkhauTextBox
            // 
            this.matkhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "Matkhau", true));
            this.matkhauTextBox.Location = new System.Drawing.Point(503, 307);
            this.matkhauTextBox.Name = "matkhauTextBox";
            this.matkhauTextBox.Size = new System.Drawing.Size(175, 22);
            this.matkhauTextBox.TabIndex = 20;
            // 
            // gmailTextBox
            // 
            this.gmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "Gmail", true));
            this.gmailTextBox.Location = new System.Drawing.Point(65, 344);
            this.gmailTextBox.Name = "gmailTextBox";
            this.gmailTextBox.Size = new System.Drawing.Size(171, 22);
            this.gmailTextBox.TabIndex = 21;
            // 
            // hotenTextBox
            // 
            this.hotenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "Hoten", true));
            this.hotenTextBox.Location = new System.Drawing.Point(294, 347);
            this.hotenTextBox.Name = "hotenTextBox";
            this.hotenTextBox.Size = new System.Drawing.Size(145, 22);
            this.hotenTextBox.TabIndex = 22;
            // 
            // gioitinhTextBox
            // 
            this.gioitinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "Gioitinh", true));
            this.gioitinhTextBox.Location = new System.Drawing.Point(740, 350);
            this.gioitinhTextBox.Name = "gioitinhTextBox";
            this.gioitinhTextBox.Size = new System.Drawing.Size(63, 22);
            this.gioitinhTextBox.TabIndex = 23;
            // 
            // ingameTextBox
            // 
            this.ingameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "ingame", true));
            this.ingameTextBox.Location = new System.Drawing.Point(519, 350);
            this.ingameTextBox.Name = "ingameTextBox";
            this.ingameTextBox.Size = new System.Drawing.Size(155, 22);
            this.ingameTextBox.TabIndex = 24;
            // 
            // modeTextBox
            // 
            this.modeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_InfBindingSource, "mode", true));
            this.modeTextBox.Location = new System.Drawing.Point(749, 314);
            this.modeTextBox.Name = "modeTextBox";
            this.modeTextBox.Size = new System.Drawing.Size(54, 22);
            this.modeTextBox.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Taikhoan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Taikhoan";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Matkhau";
            this.dataGridViewTextBoxColumn3.HeaderText = "Matkhau";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gmail";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gmail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Hoten";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hoten";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gioitinh";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gioitinh";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ingame";
            this.dataGridViewTextBoxColumn7.HeaderText = "ingame";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "mode";
            this.dataGridViewTextBoxColumn8.HeaderText = "mode";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // Admin_MainWork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 458);
            this.Controls.Add(modeLabel);
            this.Controls.Add(this.modeTextBox);
            this.Controls.Add(ingameLabel);
            this.Controls.Add(this.ingameTextBox);
            this.Controls.Add(gioitinhLabel);
            this.Controls.Add(this.gioitinhTextBox);
            this.Controls.Add(hotenLabel);
            this.Controls.Add(this.hotenTextBox);
            this.Controls.Add(gmailLabel);
            this.Controls.Add(this.gmailTextBox);
            this.Controls.Add(matkhauLabel);
            this.Controls.Add(this.matkhauTextBox);
            this.Controls.Add(taikhoanLabel);
            this.Controls.Add(this.taikhoanTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.user_InfDataGridView);
            this.Controls.Add(this.user_InfBindingNavigator);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName_Of_Work_Form1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.kryptonButton1);
            this.Name = "Admin_MainWork_Form";
            this.ShowIcon = false;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 1;
            this.Text = "Main_Work_Form";
            this.Load += new System.EventHandler(this.Admin_MainWork_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_LTTQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_InfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_InfBindingNavigator)).EndInit();
            this.user_InfBindingNavigator.ResumeLayout(false);
            this.user_InfBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_InfDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private System.Windows.Forms.Label lblName_Of_Work_Form1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private DOAN_LTTQDataSet dOAN_LTTQDataSet;
        private System.Windows.Forms.BindingSource user_InfBindingSource;
        private DOAN_LTTQDataSetTableAdapters.User_InfTableAdapter user_InfTableAdapter;
        private DOAN_LTTQDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_InfBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton user_InfBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView user_InfDataGridView;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox taikhoanTextBox;
        private System.Windows.Forms.TextBox matkhauTextBox;
        private System.Windows.Forms.TextBox gmailTextBox;
        private System.Windows.Forms.TextBox hotenTextBox;
        private System.Windows.Forms.TextBox gioitinhTextBox;
        private System.Windows.Forms.TextBox ingameTextBox;
        private System.Windows.Forms.TextBox modeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

