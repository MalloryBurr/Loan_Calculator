// Jozef Nicaj, Joe Martinez
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
        //to be used in calculate click and sent through payment options
        private double amount = 0;
        private double interest = 0;

        private void Calculate_Click(object sender, EventArgs e)
        {
            //create variables for the textbox that is converted to double, takes information from monthlyPayment function
            amount = Convert.ToDouble(txtAmount.Text);
            interest = Convert.ToDouble(txtInterestRate.Text);
            double time = Convert.ToDouble(txtMonths.Text);
            double final = monthlyPayment(amount, time, interest);
            string monthly = final.ToString("f2");
            txtEstimatedPayment.Text = monthly;
            //displays monthly payment through principal with interest function
            double estimatedpayment = Convert.ToDouble(txtEstimatedPayment.Text);
            double principal = principalWithInterest(estimatedpayment, time);
            string principalpayment = principal.ToString("f2"); //converted to 2 decimal places
            txtPrincipal.Text = principalpayment;
            double principalwithinterest = Convert.ToDouble(txtPrincipal.Text);
            // call InterestOnly function to receive the interest value
            double interestOnly = InterestOnly(principalwithinterest, amount); 
            string interestValueOnly = interestOnly.ToString("C"); //currency
            txtInterestOnly.Text = interestValueOnly;
            //lists payments from initial payment month to end payment month
            lstPayments.Items.Clear();
            double principalRemaining = double.Parse(txtPrincipal.Text);
            double principalPayment = double.Parse(txtEstimatedPayment.Text);
            int p3 = int.Parse(txtMonths.Text);
            double balance = principalRemaining;
            //for loop to read from 1 to the end of payment month and decrement the estimated monthly payment
            for (int i = 1; i <= p3; i++)
            {
                balance = (balance) - (principalPayment);
                 //display each value of list with currency, loop
                lstPayments.Items.Add("Month " + " \t " + i.ToString() + " \t " + balance.ToString("C"));
            }
            
            //static values for chart with label and legend description
            chart1.Series["Undergraduate Subsidized & Unsubsidized"].Points.Add(4.45);
            chart1.Series["Undergraduate Subsidized & Unsubsidized"].Points[0].LegendText = "Undergraduate Subsidized & Unsubsidized";
            chart1.Series["Undergraduate Subsidized & Unsubsidized"].Points[0].Label = "4.45%";
            
            //static valeus for chart with label and legend description
            chart1.Series["Graduate Subsidized & Unsubsidized"].Points.Add(6.08);
            chart1.Series["Graduate Subsidized & Unsubsidized"].Points[0].LegendText = "Graduate Subsidized & Unsubsidized";
            chart1.Series["Graduate Subsidized & Unsubsidized"].Points[0].Label = "6.08%";

            //static values for chart with label and legend description
            chart1.Series["Parent Plus"].Points.Add(7.08);
            chart1.Series["Parent Plus"].Points[0].LegendText = "Parent Plus";
            chart1.Series["Parent Plus"].Points[0].Label = "7.08%";
            
            //value of interest that is inputted is put in the placeholder for graph
            chart1.Series["Yours"].Points.Add(interest);
            chart1.Series["Yours"].Points[0].LegendText = "Yours";
            
        }
        // function to get the interest, total payment with interest - initial loan amount
        public static double InterestOnly (double initialAmount, double finalInterest)
        {
            double interestOnlyValue;
            interestOnlyValue = initialAmount - finalInterest;
            return (interestOnlyValue);

        }
        // function to calculate total value of principal with ineterest, multiplies monthly payment by duration in months
        public static double principalWithInterest(double monthlyValue, double loanDuration)
        {
            double Total;
            Total = (monthlyValue) * (loanDuration);
            return (Total);
        }
        //monthly payment function of compounded interest of a value given that the interest is a whole value (ie. 8 = 8% not .08)
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
        //clear button that clears all valuable information inputted
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtEstimatedPayment.Clear();
            txtInterestRate.Clear();
            txtMonths.Clear();
            txtPrincipal.Clear();
            txtInterestOnly.Clear();
            lstPayments.Items.Clear();
            
        }

        private void ExistingLoan_Load(object sender, EventArgs e)
        {

        }
        //restrict input besides values from 0-9, deletes invalid text input
        private void txtMonths_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMonths.Text, "[^0-9]"))
            {
                MessageBox.Show("This area is reserved for numbers only, please input a number 0-9.");
                txtMonths.Text = txtMonths.Text.Remove(txtMonths.Text.Length - 1);
            }
        }
        //restrict input besides values from 0-9, deletes invalid text input
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("This area is reserved for numbers only, please input a number 0-9.");
                txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1);
            }
        }
        //link to payment options
        private void paymentOptions_Click(object sender, EventArgs e)
        {
            PayOptions pay = new PayOptions(amount, interest);
            pay.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
