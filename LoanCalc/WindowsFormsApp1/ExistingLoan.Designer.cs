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
            this.grpExistingLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter information for an existing loan";
            // 
            // grpExistingLoan
            // 
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
            this.grpExistingLoan.Location = new System.Drawing.Point(251, 103);
            this.grpExistingLoan.Name = "grpExistingLoan";
            this.grpExistingLoan.Size = new System.Drawing.Size(366, 295);
            this.grpExistingLoan.TabIndex = 11;
            this.grpExistingLoan.TabStop = false;
            this.grpExistingLoan.Text = "Existing Loan Calculator";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Principal with interest";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(83, 245);
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
            this.lblInterest.Size = new System.Drawing.Size(89, 17);
            this.lblInterest.TabIndex = 2;
            this.lblInterest.Text = "Interest Rate";
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Location = new System.Drawing.Point(49, 114);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(120, 17);
            this.lblTimePeriod.TabIndex = 5;
            this.lblTimePeriod.Text = "Months remaining";
            this.lblTimePeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstimatedMonthlyPayment
            // 
            this.lblEstimatedMonthlyPayment.AutoSize = true;
            this.lblEstimatedMonthlyPayment.Location = new System.Drawing.Point(19, 154);
            this.lblEstimatedMonthlyPayment.Name = "lblEstimatedMonthlyPayment";
            this.lblEstimatedMonthlyPayment.Size = new System.Drawing.Size(196, 17);
            this.lblEstimatedMonthlyPayment.TabIndex = 6;
            this.lblEstimatedMonthlyPayment.Text = "Estimated payment per month";
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
            // 
            // ExistingLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 444);
            this.Controls.Add(this.grpExistingLoan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExistingLoan";
            this.Text = "Existing Loan";
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
    }
}