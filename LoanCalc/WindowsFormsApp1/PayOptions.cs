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
    public partial class PayOptions : Form
    {
        public PayOptions()
        {
            InitializeComponent();
        }

        public PayOptions(double total_Payment, double interest_Rate)
        {
            
            InitializeComponent();
            displayPaymentOptions(total_Payment, interest_Rate);
        }
        //displays a list of payment time schedules
        private void displayPaymentOptions(double payment, double i_rate)
        {
            double totalOwed = payment;
            double interest = i_rate;
            string totalBeforePayment = totalOwed.ToString("f2");
            txtTotalAmountOwed.Text = totalBeforePayment;
            txtInterestRate.Text = interest.ToString();

            txtFiveYear.Text = (principalWithInterest(monthlyPayment(payment, 70, interest), 70)).ToString("f2");
            txtTenYear.Text = (principalWithInterest(monthlyPayment(payment, 120, interest), 120)).ToString("f2");
            txtFifteenYear.Text = (principalWithInterest(monthlyPayment(payment, 180, interest), 180)).ToString("f2");
            txtTwentyYear.Text = (principalWithInterest(monthlyPayment(payment, 240, interest), 240)).ToString("f2");
        }

        //calculates the total amount payed with interest after a certain amount of time
        public static double principalWithInterest(double monthlyPayment, double loanDuration)
        {
            double Total;
            Total = (monthlyPayment) * (loanDuration);
            return (Total);
        }

        //calculates the monthly payment for a time frame
        public static double monthlyPayment(double paymentAmount, double remainingMonths, double interestRate)
        {
            double rate, months, amount;
            double monthlyPayment;
            rate = (1 + interestRate / 1200);
            months = remainingMonths;
            amount = Math.Pow(rate, months);
            amount = 1 / amount;
            amount = 1 - amount;
            monthlyPayment = (paymentAmount) * (interestRate / 1200) / amount;
            return (monthlyPayment);
        }

        private void PayOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
