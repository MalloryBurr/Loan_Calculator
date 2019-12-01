namespace WindowsFormsApp1
{
    partial class ExistingLoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpExistingLoan = new System.Windows.Forms.GroupBox();
            this.paymentOptions = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblExisting = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.lblEstimatedMonthlyPayment = new System.Windows.Forms.Label();
            this.txtEstimatedPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.lblInterestOnly = new System.Windows.Forms.Label();
            this.txtInterestOnly = new System.Windows.Forms.TextBox();
            this.grpExistingLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter information for an existing loan";
            // 
            // grpExistingLoan
            // 
            this.grpExistingLoan.Controls.Add(this.txtInterestOnly);
            this.grpExistingLoan.Controls.Add(this.lblInterestOnly);
            this.grpExistingLoan.Controls.Add(this.lstPayments);
            this.grpExistingLoan.Controls.Add(this.paymentOptions);
            this.grpExistingLoan.Controls.Add(this.btnClear);
            this.grpExistingLoan.Controls.Add(this.txtPrincipal);
            this.grpExistingLoan.Controls.Add(this.label2);
            this.grpExistingLoan.Controls.Add(this.Calculate);
            this.grpExistingLoan.Controls.Add(this.txtAmount);
            this.grpExistingLoan.Controls.Add(this.lblExisting);
            this.grpExistingLoan.Controls.Add(this.lblInterest);
            this.grpExistingLoan.Controls.Add(this.lblTimePeriod);
            this.grpExistingLoan.Controls.Add(this.lblEstimatedMonthlyPayment);
            this.grpExistingLoan.Controls.Add(this.txtEstimatedPayment);
            this.grpExistingLoan.Controls.Add(this.txtInterestRate);
            this.grpExistingLoan.Controls.Add(this.txtMonths);
            this.grpExistingLoan.Location = new System.Drawing.Point(33, 82);
            this.grpExistingLoan.Name = "grpExistingLoan";
            this.grpExistingLoan.Size = new System.Drawing.Size(588, 300);
            this.grpExistingLoan.TabIndex = 11;
            this.grpExistingLoan.TabStop = false;
            this.grpExistingLoan.Text = "Existing Loan Calculator";
            // 
            // paymentOptions
            // 
            this.paymentOptions.Location = new System.Drawing.Point(398, 262);
            this.paymentOptions.Margin = new System.Windows.Forms.Padding(2);
            this.paymentOptions.Name = "paymentOptions";
            this.paymentOptions.Size = new System.Drawing.Size(132, 23);
            this.paymentOptions.TabIndex = 12;
            this.paymentOptions.Text = "Payment Options";
            this.paymentOptions.UseVisualStyleBackColor = true;
            this.paymentOptions.Click += new System.EventHandler(this.paymentOptions_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(487, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(244, 195);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ReadOnly = true;
            this.txtPrincipal.Size = new System.Drawing.Size(100, 22);
            this.txtPrincipal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Principal with Interest: $";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(381, 234);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(86, 23);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(244, 35);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblExisting
            // 
            this.lblExisting.AutoSize = true;
            this.lblExisting.Location = new System.Drawing.Point(33, 35);
            this.lblExisting.Name = "lblExisting";
            this.lblExisting.Size = new System.Drawing.Size(182, 17);
            this.lblExisting.TabIndex = 1;
            this.lblExisting.Text = "Enter Existing Loan Amount";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(69, 74);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(109, 17);
            this.lblInterest.TabIndex = 2;
            this.lblInterest.Text = "Interest Rate: %";
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(49, 114);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(124, 17);
            this.lblTimePeriod.TabIndex = 5;
            this.lblTimePeriod.Text = "Months remaining:";
            this.lblTimePeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstimatedMonthlyPayment
            // 
            this.lblEstimatedMonthlyPayment.AutoSize = true;
            this.lblEstimatedMonthlyPayment.Location = new System.Drawing.Point(19, 154);
            this.lblEstimatedMonthlyPayment.Name = "lblEstimatedMonthlyPayment";
            this.lblEstimatedMonthlyPayment.Size = new System.Drawing.Size(213, 17);
            this.lblEstimatedMonthlyPayment.TabIndex = 6;
            this.lblEstimatedMonthlyPayment.Text = "Estimated Payment per Month: $";
            // 
            // txtEstimatedPayment
            // 
            this.txtEstimatedPayment.Location = new System.Drawing.Point(244, 154);
            this.txtEstimatedPayment.Name = "txtEstimatedPayment";
            this.txtEstimatedPayment.ReadOnly = true;
            this.txtEstimatedPayment.Size = new System.Drawing.Size(100, 22);
            this.txtEstimatedPayment.TabIndex = 8;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(244, 74);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRate.TabIndex = 4;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(244, 114);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 22);
            this.txtMonths.TabIndex = 7;
            this.txtMonths.TextChanged += new System.EventHandler(this.txtMonths_TextChanged);
            // 
            // lstPayments
            // 
            this.lstPayments.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.ItemHeight = 16;
            this.lstPayments.Location = new System.Drawing.Point(350, 37);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(232, 180);
            this.lstPayments.TabIndex = 13;
            // 
            // lblInterestOnly
            // 
            this.lblInterestOnly.AutoSize = true;
            this.lblInterestOnly.Location = new System.Drawing.Point(82, 234);
            this.lblInterestOnly.Name = "lblInterestOnly";
            this.lblInterestOnly.Size = new System.Drawing.Size(59, 17);
            this.lblInterestOnly.TabIndex = 14;
            this.lblInterestOnly.Text = "Interest:";
            // 
            // txtInterestOnly
            // 
            this.txtInterestOnly.Location = new System.Drawing.Point(244, 234);
            this.txtInterestOnly.Name = "txtInterestOnly";
            this.txtInterestOnly.ReadOnly = true;
            this.txtInterestOnly.Size = new System.Drawing.Size(100, 22);
            this.txtInterestOnly.TabIndex = 15;
            // 
            // ExistingLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 444);
            this.Controls.Add(this.grpExistingLoan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExistingLoan";
            this.Text = "Existing Loan";
            this.Load += new System.EventHandler(this.ExistingLoan_Load);
            this.grpExistingLoan.ResumeLayout(false);
            this.grpExistingLoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpExistingLoan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblExisting;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.Label lblEstimatedMonthlyPayment;
        private System.Windows.Forms.TextBox txtEstimatedPayment;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Button paymentOptions;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.TextBox txtInterestOnly;
        private System.Windows.Forms.Label lblInterestOnly;
    }
}
