using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ExistingLoan : Form
    {
        public ExistingLoan()
        {
            InitializeComponent();
        }

        private void existingLoan_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            double interest = Convert.ToDouble(txtInterestRate.Text);
            double time = Convert.ToDouble(txtMonths.Text);
            double final = monthlyPayment(amount, time, interest);
            string monthly = final.ToString("f2");
            txtEstimatedPayment.Text = monthly;

            double estimatedpayment = Convert.ToDouble(txtEstimatedPayment.Text);
            double principal = principalWithInterest(estimatedpayment, time);
            string principalpayment = principal.ToString("f2");
            txtPrincipal.Text = principalpayment;
        }
        public static double principalWithInterest(double monthlyValue, double loanDuration)
        {
            double Total;
            Total = (monthlyValue) * (loanDuration);
            return (Total);
        }
        public static double monthlyPayment(double existingAmount, double remainingMonths, double interestRate)
        {
            double rate, months, amount;
            double monthlyPayment;
            rate = (1 + interestRate / 1200);
            months = remainingMonths;
            amount = Math.Pow(rate, months);
            amount = 1 / amount;
            amount = 1 - amount;
            monthlyPayment = (existingAmount) * (interestRate / 1200) / amount;
            return (monthlyPayment);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtEstimatedPayment.Clear();
            txtInterestRate.Clear();
            txtMonths.Clear();
            txtPrincipal.Clear();
        }
    }
}
