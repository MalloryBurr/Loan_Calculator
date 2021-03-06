﻿namespace WindowsFormsApp1
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
            this.universityInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanCalcDatabaseDataSet = new WindowsFormsApp1.LoanCalcDatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
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
            this.textPaymentOptions = new System.Windows.Forms.Button();
            this.universityInfoTableAdapter = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.universityInfoDataGridView.Location = new System.Drawing.Point(477, 44);
            this.universityInfoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.universityInfoDataGridView.Name = "universityInfoDataGridView";
            this.universityInfoDataGridView.RowTemplate.Height = 24;
            this.universityInfoDataGridView.Size = new System.Drawing.Size(431, 239);
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
            // universityInfoBindingSource
            // 
            this.universityInfoBindingSource.DataMember = "UniversityInfo";
            this.universityInfoBindingSource.DataSource = this.loanCalcDatabaseDataSet;
            // 
            // loanCalcDatabaseDataSet
            // 
            this.loanCalcDatabaseDataSet.DataSetName = "LoanCalcDatabaseDataSet";
            this.loanCalcDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database of university info:";
            // 
            // calcButton
            // 
            this.calcButton.AccessibleName = "Calculate";
            this.calcButton.Location = new System.Drawing.Point(121, 327);
            this.calcButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(157, 42);
            this.calcButton.TabIndex = 48;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(253, 185);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 22);
            this.textBox6.TabIndex = 47;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(253, 263);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(89, 22);
            this.textBox5.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "You owe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Duration in years";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cost per Credit Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Credit Hours";
            // 
            // Uni
            // 
            this.Uni.AutoSize = true;
            this.Uni.Location = new System.Drawing.Point(25, 32);
            this.Uni.Name = "Uni";
            this.Uni.Size = new System.Drawing.Size(111, 17);
            this.Uni.TabIndex = 39;
            this.Uni.Text = "University Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(253, 145);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 22);
            this.textBox4.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 106);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 22);
            this.textBox3.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 22);
            this.textBox2.TabIndex = 36;
            // 
            // uniName
            // 
            this.uniName.Location = new System.Drawing.Point(253, 28);
            this.uniName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uniName.Name = "uniName";
            this.uniName.Size = new System.Drawing.Size(89, 22);
            this.uniName.TabIndex = 35;
            // 
            // monthlyPaymentsLabel
            // 
            this.monthlyPaymentsLabel.AutoSize = true;
            this.monthlyPaymentsLabel.Location = new System.Drawing.Point(25, 229);
            this.monthlyPaymentsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.monthlyPaymentsLabel.Name = "monthlyPaymentsLabel";
            this.monthlyPaymentsLabel.Size = new System.Drawing.Size(123, 17);
            this.monthlyPaymentsLabel.TabIndex = 49;
            this.monthlyPaymentsLabel.Text = "Monthly Payments";
            // 
            // textMonthlyPayments
            // 
            this.textMonthlyPayments.BackColor = System.Drawing.SystemColors.Control;
            this.textMonthlyPayments.Location = new System.Drawing.Point(253, 225);
            this.textMonthlyPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textMonthlyPayments.Name = "textMonthlyPayments";
            this.textMonthlyPayments.ReadOnly = true;
            this.textMonthlyPayments.Size = new System.Drawing.Size(89, 22);
            this.textMonthlyPayments.TabIndex = 50;
            // 
            // textPaymentOptions
            // 
            this.textPaymentOptions.Location = new System.Drawing.Point(628, 327);
            this.textPaymentOptions.Margin = new System.Windows.Forms.Padding(1);
            this.textPaymentOptions.Name = "textPaymentOptions";
            this.textPaymentOptions.Size = new System.Drawing.Size(157, 42);
            this.textPaymentOptions.TabIndex = 51;
            this.textPaymentOptions.Text = "Payment Options";
            this.textPaymentOptions.UseVisualStyleBackColor = true;
            this.textPaymentOptions.Click += new System.EventHandler(this.textPaymentOptions_Click);
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
            // NewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 412);
            this.Controls.Add(this.textPaymentOptions);
            this.Controls.Add(this.textMonthlyPayments);
            this.Controls.Add(this.monthlyPaymentsLabel);
            this.Controls.Add(this.calcButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewLoan";
            this.Text = "New Loan";
            this.Load += new System.EventHandler(this.NewLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.Button calcButton;
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
        private System.Windows.Forms.Button textPaymentOptions;
    }
}