namespace Admin
{
    partial class Admin_Work_Form_ForElse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Work_Form_ForElse));
            this.databaseOfMineSweeperDataSet = new Admin.DatabaseOfMineSweeperDataSet();
            this.pLAYER_FRIENDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYER_FRIENDSTableAdapter = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_FRIENDSTableAdapter();
            this.tableAdapterManager = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager();
            this.pLAYER_SCORETableAdapter = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_SCORETableAdapter();
            this.pLAYER_FRIENDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pLAYER_FRIENDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pLAYER_FRIENDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAYER_SCOREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYER_SCOREDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Player_FrList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Player_Score = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Choose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btbNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfMineSweeperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingNavigator)).BeginInit();
            this.pLAYER_FRIENDSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_SCOREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_SCOREDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseOfMineSweeperDataSet
            // 
            this.databaseOfMineSweeperDataSet.DataSetName = "DatabaseOfMineSweeperDataSet";
            this.databaseOfMineSweeperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLAYER_FRIENDSBindingSource
            // 
            this.pLAYER_FRIENDSBindingSource.DataMember = "PLAYER_FRIENDS";
            this.pLAYER_FRIENDSBindingSource.DataSource = this.databaseOfMineSweeperDataSet;
            // 
            // pLAYER_FRIENDSTableAdapter
            // 
            this.pLAYER_FRIENDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMIN_LOGINTableAdapter = null;
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PLAYER_FRIENDSTableAdapter = this.pLAYER_FRIENDSTableAdapter;
            this.tableAdapterManager.PLAYER_LOGINTableAdapter = null;
            this.tableAdapterManager.PLAYER_SCORETableAdapter = this.pLAYER_SCORETableAdapter;
            this.tableAdapterManager.PLAYERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin.DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLAYER_SCORETableAdapter
            // 
            this.pLAYER_SCORETableAdapter.ClearBeforeFill = true;
            // 
            // pLAYER_FRIENDSBindingNavigator
            // 
            this.pLAYER_FRIENDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pLAYER_FRIENDSBindingNavigator.BindingSource = this.pLAYER_FRIENDSBindingSource;
            this.pLAYER_FRIENDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pLAYER_FRIENDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pLAYER_FRIENDSBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pLAYER_FRIENDSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pLAYER_FRIENDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pLAYER_FRIENDSBindingNavigatorSaveItem});
            this.pLAYER_FRIENDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pLAYER_FRIENDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pLAYER_FRIENDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pLAYER_FRIENDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pLAYER_FRIENDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pLAYER_FRIENDSBindingNavigator.Name = "pLAYER_FRIENDSBindingNavigator";
            this.pLAYER_FRIENDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pLAYER_FRIENDSBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.pLAYER_FRIENDSBindingNavigator.TabIndex = 0;
            this.pLAYER_FRIENDSBindingNavigator.Text = "bindingNavigator1";
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
            // pLAYER_FRIENDSBindingNavigatorSaveItem
            // 
            this.pLAYER_FRIENDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pLAYER_FRIENDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pLAYER_FRIENDSBindingNavigatorSaveItem.Image")));
            this.pLAYER_FRIENDSBindingNavigatorSaveItem.Name = "pLAYER_FRIENDSBindingNavigatorSaveItem";
            this.pLAYER_FRIENDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.pLAYER_FRIENDSBindingNavigatorSaveItem.Text = "Save Data";
            this.pLAYER_FRIENDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pLAYER_FRIENDSBindingNavigatorSaveItem_Click);
            // 
            // pLAYER_FRIENDSDataGridView
            // 
            this.pLAYER_FRIENDSDataGridView.AutoGenerateColumns = false;
            this.pLAYER_FRIENDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pLAYER_FRIENDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.pLAYER_FRIENDSDataGridView.DataSource = this.pLAYER_FRIENDSBindingSource;
            this.pLAYER_FRIENDSDataGridView.Location = new System.Drawing.Point(21, 83);
            this.pLAYER_FRIENDSDataGridView.Name = "pLAYER_FRIENDSDataGridView";
            this.pLAYER_FRIENDSDataGridView.RowHeadersWidth = 51;
            this.pLAYER_FRIENDSDataGridView.RowTemplate.Height = 24;
            this.pLAYER_FRIENDSDataGridView.Size = new System.Drawing.Size(317, 223);
            this.pLAYER_FRIENDSDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PLAYER_FRIEND_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PLAYER_FRIEND_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // pLAYER_SCOREBindingSource
            // 
            this.pLAYER_SCOREBindingSource.DataMember = "PLAYER_SCORE";
            this.pLAYER_SCOREBindingSource.DataSource = this.databaseOfMineSweeperDataSet;
            // 
            // pLAYER_SCOREDataGridView
            // 
            this.pLAYER_SCOREDataGridView.AutoGenerateColumns = false;
            this.pLAYER_SCOREDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pLAYER_SCOREDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pLAYER_SCOREDataGridView.DataSource = this.pLAYER_SCOREBindingSource;
            this.pLAYER_SCOREDataGridView.Location = new System.Drawing.Point(356, 83);
            this.pLAYER_SCOREDataGridView.Name = "pLAYER_SCOREDataGridView";
            this.pLAYER_SCOREDataGridView.RowHeadersWidth = 51;
            this.pLAYER_SCOREDataGridView.RowTemplate.Height = 24;
            this.pLAYER_SCOREDataGridView.Size = new System.Drawing.Size(432, 223);
            this.pLAYER_SCOREDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PLAYER_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PLAYER_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PLAYER_ATTEMPT";
            this.dataGridViewTextBoxColumn4.HeaderText = "PLAYER_ATTEMPT";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SCORE";
            this.dataGridViewTextBoxColumn5.HeaderText = "SCORE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // lbl_Player_FrList
            // 
            this.lbl_Player_FrList.AutoSize = false;
            this.lbl_Player_FrList.Location = new System.Drawing.Point(83, 52);
            this.lbl_Player_FrList.Name = "lbl_Player_FrList";
            this.lbl_Player_FrList.Size = new System.Drawing.Size(171, 25);
            this.lbl_Player_FrList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_FrList.TabIndex = 3;
            this.lbl_Player_FrList.Values.Text = "Player FriendList";
            // 
            // lbl_Player_Score
            // 
            this.lbl_Player_Score.AutoSize = false;
            this.lbl_Player_Score.Location = new System.Drawing.Point(509, 52);
            this.lbl_Player_Score.Name = "lbl_Player_Score";
            this.lbl_Player_Score.Size = new System.Drawing.Size(139, 25);
            this.lbl_Player_Score.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_Score.TabIndex = 4;
            this.lbl_Player_Score.Values.Text = "Player Score ";
            // 
            // btn_Choose
            // 
            this.btn_Choose.Location = new System.Drawing.Point(443, 344);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(95, 45);
            this.btn_Choose.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Choose.StateCommon.Border.Rounding = 15;
            this.btn_Choose.StateCommon.Border.Width = 1;
            this.btn_Choose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Choose.TabIndex = 5;
            this.btn_Choose.Values.Text = "Choose";
            // 
            // btbNext
            // 
            this.btbNext.Location = new System.Drawing.Point(595, 344);
            this.btbNext.Name = "btbNext";
            this.btbNext.Size = new System.Drawing.Size(95, 45);
            this.btbNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btbNext.StateCommon.Border.Rounding = 15;
            this.btbNext.StateCommon.Border.Width = 1;
            this.btbNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbNext.TabIndex = 6;
            this.btbNext.Values.Text = "Next";
            this.btbNext.Click += new System.EventHandler(this.btbNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(67, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 45);
            this.btnExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateCommon.Border.Rounding = 15;
            this.btnExit.StateCommon.Border.Width = 1;
            this.btnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TabIndex = 7;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Admin_Work_Form_ForElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btbNext);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.lbl_Player_Score);
            this.Controls.Add(this.lbl_Player_FrList);
            this.Controls.Add(this.pLAYER_SCOREDataGridView);
            this.Controls.Add(this.pLAYER_FRIENDSDataGridView);
            this.Controls.Add(this.pLAYER_FRIENDSBindingNavigator);
            this.Name = "Admin_Work_Form_ForElse";
            this.Text = "Admin_Work_Form_ForElse";
            this.Load += new System.EventHandler(this.Admin_Work_Form_ForElse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfMineSweeperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingNavigator)).EndInit();
            this.pLAYER_FRIENDSBindingNavigator.ResumeLayout(false);
            this.pLAYER_FRIENDSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_SCOREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_SCOREDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseOfMineSweeperDataSet databaseOfMineSweeperDataSet;
        private System.Windows.Forms.BindingSource pLAYER_FRIENDSBindingSource;
        private DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_FRIENDSTableAdapter pLAYER_FRIENDSTableAdapter;
        private DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pLAYER_FRIENDSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pLAYER_FRIENDSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pLAYER_FRIENDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_SCORETableAdapter pLAYER_SCORETableAdapter;
        private System.Windows.Forms.BindingSource pLAYER_SCOREBindingSource;
        private System.Windows.Forms.DataGridView pLAYER_SCOREDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Player_FrList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Player_Score;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Choose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btbNext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
    }
}