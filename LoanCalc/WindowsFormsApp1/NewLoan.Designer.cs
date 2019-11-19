namespace WindowsFormsApp1
{
    partial class NewLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLoan));
            this.loanCalcDatabaseDataSet = new WindowsFormsApp1.LoanCalcDatabaseDataSet();
            this.universityInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityInfoTableAdapter = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager();
            this.universityInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.universityInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.universityInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingNavigator)).BeginInit();
            this.universityInfoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UniversityInfoTableAdapter = this.universityInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // universityInfoDataGridView
            // 
            this.universityInfoDataGridView.AutoGenerateColumns = false;
            this.universityInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.universityInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.universityInfoDataGridView.DataSource = this.universityInfoBindingSource;
            this.universityInfoDataGridView.Location = new System.Drawing.Point(11, 61);
            this.universityInfoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.universityInfoDataGridView.Name = "universityInfoDataGridView";
            this.universityInfoDataGridView.RowTemplate.Height = 24;
            this.universityInfoDataGridView.Size = new System.Drawing.Size(632, 98);
            this.universityInfoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
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
            // universityInfoBindingNavigatorSaveItem
            // 
            this.universityInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.universityInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("universityInfoBindingNavigatorSaveItem.Image")));
            this.universityInfoBindingNavigatorSaveItem.Name = "universityInfoBindingNavigatorSaveItem";
            this.universityInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.universityInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.universityInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.universityInfoBindingNavigatorSaveItem_Click);
            // 
            // universityInfoBindingNavigator
            // 
            this.universityInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.universityInfoBindingNavigator.BindingSource = this.universityInfoBindingSource;
            this.universityInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.universityInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.universityInfoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.universityInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.universityInfoBindingNavigatorSaveItem});
            this.universityInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.universityInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.universityInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.universityInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.universityInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.universityInfoBindingNavigator.Name = "universityInfoBindingNavigator";
            this.universityInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.universityInfoBindingNavigator.Size = new System.Drawing.Size(654, 27);
            this.universityInfoBindingNavigator.TabIndex = 0;
            this.universityInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database of university info:";
            // 
            // NewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.universityInfoDataGridView);
            this.Controls.Add(this.universityInfoBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewLoan";
            this.Text = "New Loan";
            this.Load += new System.EventHandler(this.NewLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingNavigator)).EndInit();
            this.universityInfoBindingNavigator.ResumeLayout(false);
            this.universityInfoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoanCalcDatabaseDataSet loanCalcDatabaseDataSet;
        private System.Windows.Forms.BindingSource universityInfoBindingSource;
        private LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter universityInfoTableAdapter;
        private LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView universityInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton universityInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator universityInfoBindingNavigator;
        private System.Windows.Forms.Label label1;
    }
}