namespace LoanCalc_GUI
{
    partial class newLoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newLoan));
            this.label1 = new System.Windows.Forms.Label();
            this.uniInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uniInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uniInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanCalcDBDataSet = new LoanCalc_GUI.LoanCalcDBDataSet();
            this.uniInfoTableAdapter = new LoanCalc_GUI.LoanCalcDBDataSetTableAdapters.UniInfoTableAdapter();
            this.tableAdapterManager = new LoanCalc_GUI.LoanCalcDBDataSetTableAdapters.TableAdapterManager();
            this.loanCalcDatabaseDataSet = new LoanCalc_GUI.LoanCalcDatabaseDataSet();
            this.universityInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityInfoTableAdapter = new LoanCalc_GUI.LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter();
            this.tableAdapterManager1 = new LoanCalc_GUI.LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager();
            this.universityInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uniInfoBindingNavigator)).BeginInit();
            this.uniInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter information for a new loan";
            // 
            // uniInfoBindingNavigator
            // 
            this.uniInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uniInfoBindingNavigator.BindingSource = this.uniInfoBindingSource;
            this.uniInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uniInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uniInfoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uniInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uniInfoBindingNavigatorSaveItem});
            this.uniInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uniInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uniInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uniInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uniInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uniInfoBindingNavigator.Name = "uniInfoBindingNavigator";
            this.uniInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uniInfoBindingNavigator.Size = new System.Drawing.Size(750, 27);
            this.uniInfoBindingNavigator.TabIndex = 1;
            this.uniInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // uniInfoBindingNavigatorSaveItem
            // 
            this.uniInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uniInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uniInfoBindingNavigatorSaveItem.Image")));
            this.uniInfoBindingNavigatorSaveItem.Name = "uniInfoBindingNavigatorSaveItem";
            this.uniInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.uniInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.uniInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.uniInfoBindingNavigatorSaveItem_Click);
            // 
            // uniInfoDataGridView
            // 
            this.uniInfoDataGridView.AutoGenerateColumns = false;
            this.uniInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uniInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uniInfoDataGridView.DataSource = this.uniInfoBindingSource;
            this.uniInfoDataGridView.Location = new System.Drawing.Point(58, 161);
            this.uniInfoDataGridView.Name = "uniInfoDataGridView";
            this.uniInfoDataGridView.RowTemplate.Height = 24;
            this.uniInfoDataGridView.Size = new System.Drawing.Size(571, 220);
            this.uniInfoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UniversityName";
            this.dataGridViewTextBoxColumn1.HeaderText = "UniversityName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreditHours";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreditHours";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CostPerCH";
            this.dataGridViewTextBoxColumn3.HeaderText = "CostPerCH";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // uniInfoBindingSource
            // 
            this.uniInfoBindingSource.DataMember = "UniInfo";
            this.uniInfoBindingSource.DataSource = this.loanCalcDBDataSet;
            // 
            // loanCalcDBDataSet
            // 
            this.loanCalcDBDataSet.DataSetName = "LoanCalcDBDataSet";
            this.loanCalcDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uniInfoTableAdapter
            // 
            this.uniInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UniInfoTableAdapter = this.uniInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = LoanCalc_GUI.LoanCalcDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loanCalcDatabaseDataSet
            // 
            this.loanCalcDatabaseDataSet.DataSetName = "LoanCalcDatabaseDataSet";
            this.loanCalcDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universityInfoBindingSource
            // 
            this.universityInfoBindingSource.DataMember = "UniversityInfo";
            this.universityInfoBindingSource.DataSource = this.loanCalcDatabaseDataSet;
            // 
            // universityInfoTableAdapter
            // 
            this.universityInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UniversityInfoTableAdapter = this.universityInfoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = LoanCalc_GUI.LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // universityInfoDataGridView
            // 
            this.universityInfoDataGridView.AutoGenerateColumns = false;
            this.universityInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.universityInfoDataGridView.DataSource = this.universityInfoBindingSource;
            this.universityInfoDataGridView.Location = new System.Drawing.Point(44, 387);
            this.universityInfoDataGridView.Name = "universityInfoDataGridView";
            this.universityInfoDataGridView.RowTemplate.Height = 24;
            this.universityInfoDataGridView.Size = new System.Drawing.Size(620, 136);
            this.universityInfoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreditHours";
            this.dataGridViewTextBoxColumn5.HeaderText = "CreditHours";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CostPerCH";
            this.dataGridViewTextBoxColumn6.HeaderText = "CostPerCH";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // newLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.universityInfoDataGridView);
            this.Controls.Add(this.uniInfoDataGridView);
            this.Controls.Add(this.uniInfoBindingNavigator);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newLoan";
            this.Size = new System.Drawing.Size(750, 729);
            ((System.ComponentModel.ISupportInitialize)(this.uniInfoBindingNavigator)).EndInit();
            this.uniInfoBindingNavigator.ResumeLayout(false);
            this.uniInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LoanCalcDBDataSet loanCalcDBDataSet;
        private System.Windows.Forms.BindingSource uniInfoBindingSource;
        private LoanCalcDBDataSetTableAdapters.UniInfoTableAdapter uniInfoTableAdapter;
        private LoanCalcDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uniInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uniInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uniInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private LoanCalcDatabaseDataSet loanCalcDatabaseDataSet;
        private System.Windows.Forms.BindingSource universityInfoBindingSource;
        private LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter universityInfoTableAdapter;
        private LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView universityInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
