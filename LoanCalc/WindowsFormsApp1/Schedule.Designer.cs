namespace WindowsFormsApp1
{
    partial class Schedule
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
            this.loanCalcDatabaseDataSet = new WindowsFormsApp1.LoanCalcDatabaseDataSet();
            this.loanCalcDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleGV = new System.Windows.Forms.DataGridView();
            this.scheduleDataSet = new WindowsFormsApp1.ScheduleDataSet();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new WindowsFormsApp1.ScheduleDataSetTableAdapters.ScheduleTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountRemainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loanCalcDatabaseDataSet
            // 
            this.loanCalcDatabaseDataSet.DataSetName = "LoanCalcDatabaseDataSet";
            this.loanCalcDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanCalcDatabaseDataSetBindingSource
            // 
            this.loanCalcDatabaseDataSetBindingSource.DataSource = this.loanCalcDatabaseDataSet;
            this.loanCalcDatabaseDataSetBindingSource.Position = 0;
            // 
            // scheduleGV
            // 
            this.scheduleGV.AutoGenerateColumns = false;
            this.scheduleGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.amountRemainingDataGridViewTextBoxColumn});
            this.scheduleGV.DataSource = this.scheduleBindingSource;
            this.scheduleGV.Location = new System.Drawing.Point(12, 12);
            this.scheduleGV.Name = "scheduleGV";
            this.scheduleGV.Size = new System.Drawing.Size(369, 388);
            this.scheduleGV.TabIndex = 0;
            // 
            // scheduleDataSet
            // 
            this.scheduleDataSet.DataSetName = "ScheduleDataSet";
            this.scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.scheduleDataSet;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // amountRemainingDataGridViewTextBoxColumn
            // 
            this.amountRemainingDataGridViewTextBoxColumn.DataPropertyName = "AmountRemaining";
            this.amountRemainingDataGridViewTextBoxColumn.HeaderText = "AmountRemaining";
            this.amountRemainingDataGridViewTextBoxColumn.Name = "amountRemainingDataGridViewTextBoxColumn";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 412);
            this.Controls.Add(this.scheduleGV);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LoanCalcDatabaseDataSet loanCalcDatabaseDataSet;
        private System.Windows.Forms.BindingSource loanCalcDatabaseDataSetBindingSource;
        private System.Windows.Forms.DataGridView scheduleGV;
        private ScheduleDataSet scheduleDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private ScheduleDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountRemainingDataGridViewTextBoxColumn;
    }
}