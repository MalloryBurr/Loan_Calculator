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
            this.loanCalcDatabaseDataSet = new WindowsFormsApp1.LoanCalcDatabaseDataSet();
            this.universityInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityInfoTableAdapter = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager();
            this.universityInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Uni = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uniName = new System.Windows.Forms.TextBox();
            this.monthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.textMonthlyPayments = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).BeginInit();
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
            this.universityInfoDataGridView.Location = new System.Drawing.Point(672, 62);
            this.universityInfoDataGridView.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.universityInfoDataGridView.Name = "universityInfoDataGridView";
            this.universityInfoDataGridView.RowTemplate.Height = 24;
            this.universityInfoDataGridView.Size = new System.Drawing.Size(1048, 234);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database of university info:";
            // 
            // button1
            // 
            this.button1.AccessibleName = "Calculate";
            this.button1.Location = new System.Drawing.Point(238, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 81);
            this.button1.TabIndex = 48;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(378, 386);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 38);
            this.textBox6.TabIndex = 47;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(376, 556);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(176, 38);
            this.textBox5.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 556);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "You owe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 661);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 32);
            this.label7.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 32);
            this.label6.TabIndex = 43;
            this.label6.Text = "Duration in years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cost per Credit Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Credit Hours";
            // 
            // Uni
            // 
            this.Uni.AutoSize = true;
            this.Uni.Location = new System.Drawing.Point(152, 83);
            this.Uni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Uni.Name = "Uni";
            this.Uni.Size = new System.Drawing.Size(222, 32);
            this.Uni.TabIndex = 39;
            this.Uni.Text = "University Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(376, 310);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 38);
            this.textBox4.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 234);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 38);
            this.textBox3.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 153);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 38);
            this.textBox2.TabIndex = 36;
            // 
            // uniName
            // 
            this.uniName.Location = new System.Drawing.Point(378, 83);
            this.uniName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.uniName.Name = "uniName";
            this.uniName.Size = new System.Drawing.Size(176, 38);
            this.uniName.TabIndex = 35;
            // 
            // monthlyPaymentsLabel
            // 
            this.monthlyPaymentsLabel.AutoSize = true;
            this.monthlyPaymentsLabel.Location = new System.Drawing.Point(116, 464);
            this.monthlyPaymentsLabel.Name = "monthlyPaymentsLabel";
            this.monthlyPaymentsLabel.Size = new System.Drawing.Size(248, 32);
            this.monthlyPaymentsLabel.TabIndex = 49;
            this.monthlyPaymentsLabel.Text = "Monthly Payments";
            // 
            // textMonthlyPayments
            // 
            this.textMonthlyPayments.BackColor = System.Drawing.SystemColors.Control;
            this.textMonthlyPayments.Location = new System.Drawing.Point(376, 464);
            this.textMonthlyPayments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textMonthlyPayments.Name = "textMonthlyPayments";
            this.textMonthlyPayments.ReadOnly = true;
            this.textMonthlyPayments.Size = new System.Drawing.Size(176, 38);
            this.textMonthlyPayments.TabIndex = 50;
            // 
            // NewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 860);
            this.Controls.Add(this.textMonthlyPayments);
            this.Controls.Add(this.monthlyPaymentsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Uni);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.uniName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.universityInfoDataGridView);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "NewLoan";
            this.Text = "New Loan";
            this.Load += new System.EventHandler(this.NewLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Uni;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox uniName;
        private System.Windows.Forms.Label monthlyPaymentsLabel;
        private System.Windows.Forms.TextBox textMonthlyPayments;
    }
}