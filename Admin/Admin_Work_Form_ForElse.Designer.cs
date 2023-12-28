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
            this.lbl_Player_Score = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Choose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btbNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dOAN_LTTQDataSet = new Admin.DOAN_LTTQDataSet();
            this.user_ScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ScoreTableAdapter = new Admin.DOAN_LTTQDataSetTableAdapters.User_ScoreTableAdapter();
            this.tableAdapterManager = new Admin.DOAN_LTTQDataSetTableAdapters.TableAdapterManager();
            this.user_ScoreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.user_ScoreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_ScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_LTTQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ScoreBindingNavigator)).BeginInit();
            this.user_ScoreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_ScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Player_Score
            // 
            this.lbl_Player_Score.AutoSize = false;
            this.lbl_Player_Score.Location = new System.Drawing.Point(309, 46);
            this.lbl_Player_Score.Name = "lbl_Player_Score";
            this.lbl_Player_Score.Size = new System.Drawing.Size(156, 31);
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
            // dOAN_LTTQDataSet
            // 
            this.dOAN_LTTQDataSet.DataSetName = "DOAN_LTTQDataSet";
            this.dOAN_LTTQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_ScoreBindingSource
            // 
            this.user_ScoreBindingSource.DataMember = "User_Score";
            this.user_ScoreBindingSource.DataSource = this.dOAN_LTTQDataSet;
            // 
            // user_ScoreTableAdapter
            // 
            this.user_ScoreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Admin_InfTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Admin.DOAN_LTTQDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_InfTableAdapter = null;
            this.tableAdapterManager.User_ScoreTableAdapter = this.user_ScoreTableAdapter;
            // 
            // user_ScoreBindingNavigator
            // 
            this.user_ScoreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user_ScoreBindingNavigator.BindingSource = this.user_ScoreBindingSource;
            this.user_ScoreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user_ScoreBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_ScoreBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_ScoreBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.user_ScoreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.user_ScoreBindingNavigatorSaveItem});
            this.user_ScoreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user_ScoreBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.user_ScoreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.user_ScoreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.user_ScoreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.user_ScoreBindingNavigator.Name = "user_ScoreBindingNavigator";
            this.user_ScoreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user_ScoreBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.user_ScoreBindingNavigator.TabIndex = 8;
            this.user_ScoreBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // user_ScoreBindingNavigatorSaveItem
            // 
            this.user_ScoreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user_ScoreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_ScoreBindingNavigatorSaveItem.Image")));
            this.user_ScoreBindingNavigatorSaveItem.Name = "user_ScoreBindingNavigatorSaveItem";
            this.user_ScoreBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.user_ScoreBindingNavigatorSaveItem.Text = "Save Data";
            this.user_ScoreBindingNavigatorSaveItem.Click += new System.EventHandler(this.user_ScoreBindingNavigatorSaveItem_Click);
            // 
            // user_ScoreDataGridView
            // 
            this.user_ScoreDataGridView.AutoGenerateColumns = false;
            this.user_ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_ScoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.user_ScoreDataGridView.DataSource = this.user_ScoreBindingSource;
            this.user_ScoreDataGridView.Location = new System.Drawing.Point(12, 101);
            this.user_ScoreDataGridView.Name = "user_ScoreDataGridView";
            this.user_ScoreDataGridView.RowHeadersWidth = 51;
            this.user_ScoreDataGridView.RowTemplate.Height = 24;
            this.user_ScoreDataGridView.Size = new System.Drawing.Size(776, 228);
            this.user_ScoreDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "attempt";
            this.dataGridViewTextBoxColumn2.HeaderText = "attempt";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mode";
            this.dataGridViewTextBoxColumn3.HeaderText = "mode";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn4.HeaderText = "score";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn5.HeaderText = "time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // Admin_Work_Form_ForElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_ScoreDataGridView);
            this.Controls.Add(this.user_ScoreBindingNavigator);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btbNext);
            this.Controls.Add(this.btn_Choose);
            this.Controls.Add(this.lbl_Player_Score);
            this.Name = "Admin_Work_Form_ForElse";
            this.Text = "Admin_Work_Form_ForElse";
            this.Load += new System.EventHandler(this.Admin_Work_Form_ForElse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOAN_LTTQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_ScoreBindingNavigator)).EndInit();
            this.user_ScoreBindingNavigator.ResumeLayout(false);
            this.user_ScoreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_ScoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Player_Score;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Choose;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btbNext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private DOAN_LTTQDataSet dOAN_LTTQDataSet;
        private System.Windows.Forms.BindingSource user_ScoreBindingSource;
        private DOAN_LTTQDataSetTableAdapters.User_ScoreTableAdapter user_ScoreTableAdapter;
        private DOAN_LTTQDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_ScoreBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton user_ScoreBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView user_ScoreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}