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
            System.Windows.Forms.Label pLAYER_IDLabel;
            System.Windows.Forms.Label pLAYER_NAMELabel;
            System.Windows.Forms.Label pLAYER_SEXLabel;
            System.Windows.Forms.Label pLAYER_BIRTHDAYLabel;
            System.Windows.Forms.Label pLAYER_GMAILLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_MainWork_Form));
            this.databaseOfMineSweeperDataSet = new Admin.DatabaseOfMineSweeperDataSet();
            this.pLAYERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYERTableAdapter = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.PLAYERTableAdapter();
            this.tableAdapterManager = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager();
            this.pLAYERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pLAYERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pLAYERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblName_Of_Work_Form1 = new System.Windows.Forms.Label();
            this.pLAYER_IDTextBox = new System.Windows.Forms.TextBox();
            this.pLAYER_NAMETextBox = new System.Windows.Forms.TextBox();
            this.pLAYER_SEXTextBox = new System.Windows.Forms.TextBox();
            this.pLAYER_BIRTHDAYDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pLAYER_GMAILTextBox = new System.Windows.Forms.TextBox();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            pLAYER_IDLabel = new System.Windows.Forms.Label();
            pLAYER_NAMELabel = new System.Windows.Forms.Label();
            pLAYER_SEXLabel = new System.Windows.Forms.Label();
            pLAYER_BIRTHDAYLabel = new System.Windows.Forms.Label();
            pLAYER_GMAILLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfMineSweeperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERBindingNavigator)).BeginInit();
            this.pLAYERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pLAYER_IDLabel
            // 
            pLAYER_IDLabel.AutoSize = true;
            pLAYER_IDLabel.Location = new System.Drawing.Point(12, 321);
            pLAYER_IDLabel.Name = "pLAYER_IDLabel";
            pLAYER_IDLabel.Size = new System.Drawing.Size(79, 16);
            pLAYER_IDLabel.TabIndex = 6;
            pLAYER_IDLabel.Text = "PLAYER ID:";
            // 
            // pLAYER_NAMELabel
            // 
            pLAYER_NAMELabel.AutoSize = true;
            pLAYER_NAMELabel.Location = new System.Drawing.Point(237, 321);
            pLAYER_NAMELabel.Name = "pLAYER_NAMELabel";
            pLAYER_NAMELabel.Size = new System.Drawing.Size(105, 16);
            pLAYER_NAMELabel.TabIndex = 8;
            pLAYER_NAMELabel.Text = "PLAYER NAME:";
            // 
            // pLAYER_SEXLabel
            // 
            pLAYER_SEXLabel.AutoSize = true;
            pLAYER_SEXLabel.Location = new System.Drawing.Point(580, 321);
            pLAYER_SEXLabel.Name = "pLAYER_SEXLabel";
            pLAYER_SEXLabel.Size = new System.Drawing.Size(92, 16);
            pLAYER_SEXLabel.TabIndex = 10;
            pLAYER_SEXLabel.Text = "PLAYER SEX:";
            // 
            // pLAYER_BIRTHDAYLabel
            // 
            pLAYER_BIRTHDAYLabel.AutoSize = true;
            pLAYER_BIRTHDAYLabel.Location = new System.Drawing.Point(12, 369);
            pLAYER_BIRTHDAYLabel.Name = "pLAYER_BIRTHDAYLabel";
            pLAYER_BIRTHDAYLabel.Size = new System.Drawing.Size(135, 16);
            pLAYER_BIRTHDAYLabel.TabIndex = 12;
            pLAYER_BIRTHDAYLabel.Text = "PLAYER BIRTHDAY:";
            // 
            // pLAYER_GMAILLabel
            // 
            pLAYER_GMAILLabel.AutoSize = true;
            pLAYER_GMAILLabel.Location = new System.Drawing.Point(441, 366);
            pLAYER_GMAILLabel.Name = "pLAYER_GMAILLabel";
            pLAYER_GMAILLabel.Size = new System.Drawing.Size(106, 16);
            pLAYER_GMAILLabel.TabIndex = 14;
            pLAYER_GMAILLabel.Text = "PLAYER GMAIL:";
            // 
            // databaseOfMineSweeperDataSet
            // 
            this.databaseOfMineSweeperDataSet.DataSetName = "DatabaseOfMineSweeperDataSet";
            this.databaseOfMineSweeperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLAYERBindingSource
            // 
            this.pLAYERBindingSource.DataMember = "PLAYER";
            this.pLAYERBindingSource.DataSource = this.databaseOfMineSweeperDataSet;
            // 
            // pLAYERTableAdapter
            // 
            this.pLAYERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMIN_LOGINTableAdapter = null;
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PLAYER_FRIENDSTableAdapter = null;
            this.tableAdapterManager.PLAYER_LOGINTableAdapter = null;
            this.tableAdapterManager.PLAYER_SCORETableAdapter = null;
            this.tableAdapterManager.PLAYERTableAdapter = this.pLAYERTableAdapter;
            this.tableAdapterManager.UpdateOrder = Admin.DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLAYERBindingNavigator
            // 
            this.pLAYERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pLAYERBindingNavigator.BindingSource = this.pLAYERBindingSource;
            this.pLAYERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pLAYERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pLAYERBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pLAYERBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pLAYERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pLAYERBindingNavigatorSaveItem});
            this.pLAYERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pLAYERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pLAYERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pLAYERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pLAYERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pLAYERBindingNavigator.Name = "pLAYERBindingNavigator";
            this.pLAYERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pLAYERBindingNavigator.Size = new System.Drawing.Size(820, 31);
            this.pLAYERBindingNavigator.TabIndex = 0;
            this.pLAYERBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // pLAYERBindingNavigatorSaveItem
            // 
            this.pLAYERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pLAYERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pLAYERBindingNavigatorSaveItem.Image")));
            this.pLAYERBindingNavigatorSaveItem.Name = "pLAYERBindingNavigatorSaveItem";
            this.pLAYERBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pLAYERBindingNavigatorSaveItem.Text = "Save Data";
            this.pLAYERBindingNavigatorSaveItem.Click += new System.EventHandler(this.pLAYERBindingNavigatorSaveItem_Click);
            // 
            // pLAYERDataGridView
            // 
            this.pLAYERDataGridView.AutoGenerateColumns = false;
            this.pLAYERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pLAYERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pLAYERDataGridView.DataSource = this.pLAYERBindingSource;
            this.pLAYERDataGridView.Location = new System.Drawing.Point(1, 68);
            this.pLAYERDataGridView.Name = "pLAYERDataGridView";
            this.pLAYERDataGridView.RowHeadersWidth = 51;
            this.pLAYERDataGridView.RowTemplate.Height = 24;
            this.pLAYERDataGridView.Size = new System.Drawing.Size(819, 233);
            this.pLAYERDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PLAYER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PLAYER_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PLAYER_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "PLAYER_NAME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PLAYER_SEX";
            this.dataGridViewTextBoxColumn3.HeaderText = "PLAYER_SEX";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PLAYER_BIRTHDAY";
            this.dataGridViewTextBoxColumn4.HeaderText = "PLAYER_BIRTHDAY";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PLAYER_GMAIL";
            this.dataGridViewTextBoxColumn5.HeaderText = "PLAYER_GMAIL";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 45);
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 15;
            this.btnDelete.StateCommon.Border.Width = 1;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Values.Text = "Delete";
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
            this.lblName_Of_Work_Form1.Location = new System.Drawing.Point(295, 38);
            this.lblName_Of_Work_Form1.Name = "lblName_Of_Work_Form1";
            this.lblName_Of_Work_Form1.Size = new System.Drawing.Size(143, 27);
            this.lblName_Of_Work_Form1.TabIndex = 6;
            this.lblName_Of_Work_Form1.Text = "Player Detail";
            // 
            // pLAYER_IDTextBox
            // 
            this.pLAYER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLAYERBindingSource, "PLAYER_ID", true));
            this.pLAYER_IDTextBox.Location = new System.Drawing.Point(97, 318);
            this.pLAYER_IDTextBox.Name = "pLAYER_IDTextBox";
            this.pLAYER_IDTextBox.Size = new System.Drawing.Size(126, 22);
            this.pLAYER_IDTextBox.TabIndex = 7;
            // 
            // pLAYER_NAMETextBox
            // 
            this.pLAYER_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLAYERBindingSource, "PLAYER_NAME", true));
            this.pLAYER_NAMETextBox.Location = new System.Drawing.Point(348, 318);
            this.pLAYER_NAMETextBox.Name = "pLAYER_NAMETextBox";
            this.pLAYER_NAMETextBox.Size = new System.Drawing.Size(213, 22);
            this.pLAYER_NAMETextBox.TabIndex = 9;
            // 
            // pLAYER_SEXTextBox
            // 
            this.pLAYER_SEXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLAYERBindingSource, "PLAYER_SEX", true));
            this.pLAYER_SEXTextBox.Location = new System.Drawing.Point(678, 318);
            this.pLAYER_SEXTextBox.Name = "pLAYER_SEXTextBox";
            this.pLAYER_SEXTextBox.Size = new System.Drawing.Size(100, 22);
            this.pLAYER_SEXTextBox.TabIndex = 11;
            // 
            // pLAYER_BIRTHDAYDateTimePicker
            // 
            this.pLAYER_BIRTHDAYDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pLAYERBindingSource, "PLAYER_BIRTHDAY", true));
            this.pLAYER_BIRTHDAYDateTimePicker.Location = new System.Drawing.Point(153, 365);
            this.pLAYER_BIRTHDAYDateTimePicker.Name = "pLAYER_BIRTHDAYDateTimePicker";
            this.pLAYER_BIRTHDAYDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.pLAYER_BIRTHDAYDateTimePicker.TabIndex = 13;
            // 
            // pLAYER_GMAILTextBox
            // 
            this.pLAYER_GMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLAYERBindingSource, "PLAYER_GMAIL", true));
            this.pLAYER_GMAILTextBox.Location = new System.Drawing.Point(553, 363);
            this.pLAYER_GMAILTextBox.Name = "pLAYER_GMAILTextBox";
            this.pLAYER_GMAILTextBox.Size = new System.Drawing.Size(207, 22);
            this.pLAYER_GMAILTextBox.TabIndex = 15;
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
            // Admin_MainWork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 458);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(pLAYER_GMAILLabel);
            this.Controls.Add(this.pLAYER_GMAILTextBox);
            this.Controls.Add(pLAYER_BIRTHDAYLabel);
            this.Controls.Add(this.pLAYER_BIRTHDAYDateTimePicker);
            this.Controls.Add(pLAYER_SEXLabel);
            this.Controls.Add(this.pLAYER_SEXTextBox);
            this.Controls.Add(pLAYER_NAMELabel);
            this.Controls.Add(this.pLAYER_NAMETextBox);
            this.Controls.Add(pLAYER_IDLabel);
            this.Controls.Add(this.pLAYER_IDTextBox);
            this.Controls.Add(this.lblName_Of_Work_Form1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.pLAYERDataGridView);
            this.Controls.Add(this.pLAYERBindingNavigator);
            this.Name = "Admin_MainWork_Form";
            this.ShowIcon = false;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 1;
            this.Text = "Main_Work_Form";
            this.Load += new System.EventHandler(this.Admin_Work_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfMineSweeperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERBindingNavigator)).EndInit();
            this.pLAYERBindingNavigator.ResumeLayout(false);
            this.pLAYERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseOfMineSweeperDataSet databaseOfMineSweeperDataSet;
        private System.Windows.Forms.BindingSource pLAYERBindingSource;
        private DatabaseOfMineSweeperDataSetTableAdapters.PLAYERTableAdapter pLAYERTableAdapter;
        private DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pLAYERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pLAYERBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pLAYERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private System.Windows.Forms.Label lblName_Of_Work_Form1;
        private System.Windows.Forms.TextBox pLAYER_IDTextBox;
        private System.Windows.Forms.TextBox pLAYER_NAMETextBox;
        private System.Windows.Forms.TextBox pLAYER_SEXTextBox;
        private System.Windows.Forms.DateTimePicker pLAYER_BIRTHDAYDateTimePicker;
        private System.Windows.Forms.TextBox pLAYER_GMAILTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
    }
}

