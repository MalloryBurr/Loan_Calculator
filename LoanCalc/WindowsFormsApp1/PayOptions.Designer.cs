namespace WindowsFormsApp1
{
    partial class PayOptions
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
            this.txtTotalAmountOwed = new System.Windows.Forms.TextBox();
            this.totalOwed_label = new System.Windows.Forms.Label();
            this.FiveYear_label = new System.Windows.Forms.Label();
            this.TenYear_label = new System.Windows.Forms.Label();
            this.FifteenYear_label = new System.Windows.Forms.Label();
            this.TwentyYear_label = new System.Windows.Forms.Label();
            this.interestRate_label = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtFiveYear = new System.Windows.Forms.TextBox();
            this.txtTenYear = new System.Windows.Forms.TextBox();
            this.txtFifteenYear = new System.Windows.Forms.TextBox();
            this.txtTwentyYear = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.durationCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.universityInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanCalcDatabaseDataSet = new WindowsFormsApp1.LoanCalcDatabaseDataSet();
            this.loanCalcDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityInfoTableAdapter = new WindowsFormsApp1.LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalAmountOwed
            // 
            this.txtTotalAmountOwed.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalAmountOwed.Location = new System.Drawing.Point(210, 30);
            this.txtTotalAmountOwed.Margin = new System.Windows.Forms.Padding(1);
            this.txtTotalAmountOwed.Name = "txtTotalAmountOwed";
            this.txtTotalAmountOwed.ReadOnly = true;
            this.txtTotalAmountOwed.Size = new System.Drawing.Size(108, 20);
            this.txtTotalAmountOwed.TabIndex = 0;
            // 
            // totalOwed_label
            // 
            this.totalOwed_label.AutoSize = true;
            this.totalOwed_label.Location = new System.Drawing.Point(46, 33);
            this.totalOwed_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.totalOwed_label.Name = "totalOwed_label";
            this.totalOwed_label.Size = new System.Drawing.Size(101, 13);
            this.totalOwed_label.TabIndex = 1;
            this.totalOwed_label.Text = "Total Amount Owed";
            // 
            // FiveYear_label
            // 
            this.FiveYear_label.AutoSize = true;
            this.FiveYear_label.Location = new System.Drawing.Point(46, 106);
            this.FiveYear_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FiveYear_label.Name = "FiveYear_label";
            this.FiveYear_label.Size = new System.Drawing.Size(76, 13);
            this.FiveYear_label.TabIndex = 2;
            this.FiveYear_label.Text = "Five Year Plan";
            // 
            // TenYear_label
            // 
            this.TenYear_label.AutoSize = true;
            this.TenYear_label.Location = new System.Drawing.Point(47, 146);
            this.TenYear_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TenYear_label.Name = "TenYear_label";
            this.TenYear_label.Size = new System.Drawing.Size(75, 13);
            this.TenYear_label.TabIndex = 3;
            this.TenYear_label.Text = "Ten Year Plan";
            // 
            // FifteenYear_label
            // 
            this.FifteenYear_label.AutoSize = true;
            this.FifteenYear_label.Location = new System.Drawing.Point(47, 187);
            this.FifteenYear_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FifteenYear_label.Name = "FifteenYear_label";
            this.FifteenYear_label.Size = new System.Drawing.Size(88, 13);
            this.FifteenYear_label.TabIndex = 4;
            this.FifteenYear_label.Text = "Fifteen Year Plan";
            // 
            // TwentyYear_label
            // 
            this.TwentyYear_label.AutoSize = true;
            this.TwentyYear_label.Location = new System.Drawing.Point(47, 227);
            this.TwentyYear_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TwentyYear_label.Name = "TwentyYear_label";
            this.TwentyYear_label.Size = new System.Drawing.Size(91, 13);
            this.TwentyYear_label.TabIndex = 5;
            this.TwentyYear_label.Text = "Twenty Year Plan";
            // 
            // interestRate_label
            // 
            this.interestRate_label.AutoSize = true;
            this.interestRate_label.Location = new System.Drawing.Point(46, 70);
            this.interestRate_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.interestRate_label.Name = "interestRate_label";
            this.interestRate_label.Size = new System.Drawing.Size(68, 13);
            this.interestRate_label.TabIndex = 6;
            this.interestRate_label.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.BackColor = System.Drawing.SystemColors.Control;
            this.txtInterestRate.Location = new System.Drawing.Point(210, 67);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(1);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(108, 20);
            this.txtInterestRate.TabIndex = 7;
            // 
            // txtFiveYear
            // 
            this.txtFiveYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtFiveYear.Location = new System.Drawing.Point(210, 103);
            this.txtFiveYear.Margin = new System.Windows.Forms.Padding(1);
            this.txtFiveYear.Name = "txtFiveYear";
            this.txtFiveYear.ReadOnly = true;
            this.txtFiveYear.Size = new System.Drawing.Size(108, 20);
            this.txtFiveYear.TabIndex = 8;
            // 
            // txtTenYear
            // 
            this.txtTenYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenYear.Location = new System.Drawing.Point(210, 143);
            this.txtTenYear.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenYear.Name = "txtTenYear";
            this.txtTenYear.ReadOnly = true;
            this.txtTenYear.Size = new System.Drawing.Size(108, 20);
            this.txtTenYear.TabIndex = 9;
            // 
            // txtFifteenYear
            // 
            this.txtFifteenYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtFifteenYear.Location = new System.Drawing.Point(210, 184);
            this.txtFifteenYear.Margin = new System.Windows.Forms.Padding(1);
            this.txtFifteenYear.Name = "txtFifteenYear";
            this.txtFifteenYear.ReadOnly = true;
            this.txtFifteenYear.Size = new System.Drawing.Size(108, 20);
            this.txtFifteenYear.TabIndex = 10;
            // 
            // txtTwentyYear
            // 
            this.txtTwentyYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtTwentyYear.Location = new System.Drawing.Point(210, 224);
            this.txtTwentyYear.Margin = new System.Windows.Forms.Padding(1);
            this.txtTwentyYear.Name = "txtTwentyYear";
            this.txtTwentyYear.ReadOnly = true;
            this.txtTwentyYear.Size = new System.Drawing.Size(108, 20);
            this.txtTwentyYear.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(123, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 56;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // durationCB
            // 
            this.durationCB.FormattingEnabled = true;
            this.durationCB.Location = new System.Drawing.Point(123, 22);
            this.durationCB.Name = "durationCB";
            this.durationCB.Size = new System.Drawing.Size(121, 21);
            this.durationCB.TabIndex = 59;
            this.durationCB.SelectedIndexChanged += new System.EventHandler(this.durationCB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scheduleButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.durationCB);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(404, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 278);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Payments";
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(113, 229);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(131, 34);
            this.scheduleButton.TabIndex = 63;
            this.scheduleButton.Text = "Show Calendar";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Starting on:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Payment duration:";
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
            // loanCalcDatabaseDataSetBindingSource
            // 
            this.loanCalcDatabaseDataSetBindingSource.DataSource = this.loanCalcDatabaseDataSet;
            this.loanCalcDatabaseDataSetBindingSource.Position = 0;
            // 
            // universityInfoTableAdapter
            // 
            this.universityInfoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalOwed_label);
            this.groupBox2.Controls.Add(this.txtTotalAmountOwed);
            this.groupBox2.Controls.Add(this.txtTwentyYear);
            this.groupBox2.Controls.Add(this.FiveYear_label);
            this.groupBox2.Controls.Add(this.txtFifteenYear);
            this.groupBox2.Controls.Add(this.TenYear_label);
            this.groupBox2.Controls.Add(this.txtTenYear);
            this.groupBox2.Controls.Add(this.FifteenYear_label);
            this.groupBox2.Controls.Add(this.txtFiveYear);
            this.groupBox2.Controls.Add(this.TwentyYear_label);
            this.groupBox2.Controls.Add(this.txtInterestRate);
            this.groupBox2.Controls.Add(this.interestRate_label);
            this.groupBox2.Location = new System.Drawing.Point(22, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 278);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // PayOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "PayOptions";
            this.Text = "Payment Options";
            this.Load += new System.EventHandler(this.PayOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanCalcDatabaseDataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalAmountOwed;
        private System.Windows.Forms.Label totalOwed_label;
        private System.Windows.Forms.Label FiveYear_label;
        private System.Windows.Forms.Label TenYear_label;
        private System.Windows.Forms.Label FifteenYear_label;
        private System.Windows.Forms.Label TwentyYear_label;
        private System.Windows.Forms.Label interestRate_label;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtFiveYear;
        private System.Windows.Forms.TextBox txtTenYear;
        private System.Windows.Forms.TextBox txtFifteenYear;
        private System.Windows.Forms.TextBox txtTwentyYear;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox durationCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource loanCalcDatabaseDataSetBindingSource;
        private LoanCalcDatabaseDataSet loanCalcDatabaseDataSet;
        private System.Windows.Forms.BindingSource universityInfoBindingSource;
        private LoanCalcDatabaseDataSetTableAdapters.UniversityInfoTableAdapter universityInfoTableAdapter;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}