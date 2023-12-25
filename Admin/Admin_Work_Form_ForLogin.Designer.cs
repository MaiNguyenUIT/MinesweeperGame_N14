namespace Admin
{
    partial class Admin_Work_Form_ForLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Work_Form_ForLogin));
            this.pLAYER_FRIENDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pLAYER_FRIENDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOfMineSweeperDataSet = new Admin.DatabaseOfMineSweeperDataSet();
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
            this.pLAYER_FRIENDSTableAdapter = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_FRIENDSTableAdapter();
            this.tableAdapterManager = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager();
            this.pLAYER_LOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLAYER_LOGINTableAdapter = new Admin.DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_LOGINTableAdapter();
            this.pLAYER_LOGINDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFind = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblWorkFormForLogin = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingNavigator)).BeginInit();
            this.pLAYER_FRIENDSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfMineSweeperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_LOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_LOGINDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.pLAYER_FRIENDSBindingNavigator.Size = new System.Drawing.Size(782, 31);
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
            // pLAYER_FRIENDSBindingSource
            // 
            this.pLAYER_FRIENDSBindingSource.DataMember = "PLAYER_FRIENDS";
            this.pLAYER_FRIENDSBindingSource.DataSource = this.databaseOfMineSweeperDataSet;
            // 
            // databaseOfMineSweeperDataSet
            // 
            this.databaseOfMineSweeperDataSet.DataSetName = "DatabaseOfMineSweeperDataSet";
            this.databaseOfMineSweeperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.PLAYER_SCORETableAdapter = null;
            this.tableAdapterManager.PLAYERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin.DatabaseOfMineSweeperDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLAYER_LOGINBindingSource
            // 
            this.pLAYER_LOGINBindingSource.DataMember = "PLAYER_LOGIN";
            this.pLAYER_LOGINBindingSource.DataSource = this.databaseOfMineSweeperDataSet;
            // 
            // pLAYER_LOGINTableAdapter
            // 
            this.pLAYER_LOGINTableAdapter.ClearBeforeFill = true;
            // 
            // pLAYER_LOGINDataGridView
            // 
            this.pLAYER_LOGINDataGridView.AutoGenerateColumns = false;
            this.pLAYER_LOGINDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pLAYER_LOGINDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.pLAYER_LOGINDataGridView.DataSource = this.pLAYER_LOGINBindingSource;
            this.pLAYER_LOGINDataGridView.Location = new System.Drawing.Point(12, 77);
            this.pLAYER_LOGINDataGridView.Name = "pLAYER_LOGINDataGridView";
            this.pLAYER_LOGINDataGridView.RowHeadersWidth = 51;
            this.pLAYER_LOGINDataGridView.RowTemplate.Height = 24;
            this.pLAYER_LOGINDataGridView.Size = new System.Drawing.Size(716, 220);
            this.pLAYER_LOGINDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ACCOUNT";
            this.dataGridViewTextBoxColumn2.HeaderText = "ACCOUNT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn3.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IS_ONLINE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IS_ONLINE";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(392, 337);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 45);
            this.btnFind.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFind.StateCommon.Border.Rounding = 15;
            this.btnFind.StateCommon.Border.Width = 1;
            this.btnFind.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.TabIndex = 2;
            this.btnFind.Values.Text = "Find";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(585, 337);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 45);
            this.btnNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.Rounding = 15;
            this.btnNext.StateCommon.Border.Width = 1;
            this.btnNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.TabIndex = 3;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblWorkFormForLogin
            // 
            this.lblWorkFormForLogin.AutoSize = false;
            this.lblWorkFormForLogin.Location = new System.Drawing.Point(288, 33);
            this.lblWorkFormForLogin.Name = "lblWorkFormForLogin";
            this.lblWorkFormForLogin.Size = new System.Drawing.Size(142, 38);
            this.lblWorkFormForLogin.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkFormForLogin.TabIndex = 4;
            this.lblWorkFormForLogin.Values.Text = "Work Of Log In";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(36, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 45);
            this.btnExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.StateCommon.Border.Rounding = 15;
            this.btnExit.StateCommon.Border.Width = 1;
            this.btnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TabIndex = 8;
            this.btnExit.Values.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Admin_Work_Form_ForLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWorkFormForLogin);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.pLAYER_LOGINDataGridView);
            this.Controls.Add(this.pLAYER_FRIENDSBindingNavigator);
            this.Name = "Admin_Work_Form_ForLogin";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 1;
            this.Text = "Admin_Work_Form2";
            this.Load += new System.EventHandler(this.Admin_Work_Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingNavigator)).EndInit();
            this.pLAYER_FRIENDSBindingNavigator.ResumeLayout(false);
            this.pLAYER_FRIENDSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_FRIENDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOfMineSweeperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_LOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLAYER_LOGINDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource pLAYER_LOGINBindingSource;
        private DatabaseOfMineSweeperDataSetTableAdapters.PLAYER_LOGINTableAdapter pLAYER_LOGINTableAdapter;
        private System.Windows.Forms.DataGridView pLAYER_LOGINDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFind;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblWorkFormForLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
    }
}