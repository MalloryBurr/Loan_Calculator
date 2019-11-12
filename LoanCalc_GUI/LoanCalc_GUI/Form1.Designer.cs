namespace LoanCalc_GUI
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.newLoan1 = new LoanCalc_GUI.newLoan();
            this.existingLoan1 = new LoanCalc_GUI.existingLoan();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 998);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Loan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 997);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Existing Loan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1204, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Would you like to enter a new loan or an existing loan";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 997);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(293, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newLoan1
            // 
            this.newLoan1.Location = new System.Drawing.Point(-3, 1);
            this.newLoan1.Name = "newLoan1";
            this.newLoan1.Size = new System.Drawing.Size(1564, 962);
            this.newLoan1.TabIndex = 8;
            // 
            // existingLoan1
            // 
            this.existingLoan1.Location = new System.Drawing.Point(-3, 1);
            this.existingLoan1.Name = "existingLoan1";
            this.existingLoan1.Size = new System.Drawing.Size(1564, 962);
            this.existingLoan1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1562, 1132);
            this.Controls.Add(this.newLoan1);
            this.Controls.Add(this.existingLoan1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private existingLoan existingLoan1;
        private newLoan newLoan1;
    }
}

