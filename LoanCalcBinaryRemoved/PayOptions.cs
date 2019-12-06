// Joe Martinez, Mallory Burr
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("MyProjectTests")]
namespace WindowsFormsApp1
{
    public partial class PayOptions : Form
    {
        public PayOptions()
        {
            InitializeComponent();
        }

        //inherits total_payment and interest_rate from newloan or existing loan
        public PayOptions(double total_Payment, double interest_Rate)
        {
            InitializeComponent();
            displayPaymentOptions(total_Payment, interest_Rate);
        }

        //define global variables to allow passing to other functions
        double totalOwed;
        double fiveYear, tenYear, fifteenYear, twentyYear;
        DateTime date;
        private string selectedTime;


        //displays a list of payment time schedules
        public void displayPaymentOptions(double payment, double i_rate)
        {
            totalOwed = payment;
            double interest = i_rate;
            string totalBeforePayment = totalOwed.ToString("f2");
            txtTotalAmountOwed.Text = totalBeforePayment;
            txtInterestRate.Text = interest.ToString();
           
            fiveYear = (principalWithInterest(monthlyPayment(payment, 60, interest), 60));
            tenYear = (principalWithInterest(monthlyPayment(payment, 120, interest), 120));
            fifteenYear = (principalWithInterest(monthlyPayment(payment, 180, interest), 180));
            twentyYear = (principalWithInterest(monthlyPayment(payment, 240, interest), 240));

            txtFiveYear.Text = fiveYear.ToString("f2");
            txtTenYear.Text = tenYear.ToString("f2");
            txtFifteenYear.Text = fifteenYear.ToString("f2");
            txtTwentyYear.Text = twentyYear.ToString("f2");
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

        //create variable for date to save the selected date on the calendar
        public void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            date = monthCalendar1.SelectionRange.Start;
        }

        public void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void PayOptions_Load(object sender, EventArgs e)
        {
            this.universityInfoTableAdapter.Fill(this.loanCalcDatabaseDataSet.UniversityInfo);

            //insert values into duration combobox
            durationCB.Items.Add("5");
            durationCB.Items.Add("10");
            durationCB.Items.Add("15");
            durationCB.Items.Add("20");
        }

        public void durationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create switch to route logic based on duration selected
            switch (durationCB.SelectedItem.ToString())
            {
                case "5":
                    totalOwed = fiveYear;
                    break;
                case "10":
                    totalOwed = tenYear;
                    break;
                case "15":
                    totalOwed = fifteenYear;
                    break;
                case "20":
                    totalOwed = twentyYear;
                    break;
            }
        }

        public void scheduleButton_Click_1(object sender, EventArgs e)
        {
            //call schedule method to display calendar of payments
            selectedTime = durationCB.SelectedItem.ToString();
            Schedule sc = new Schedule(selectedTime, totalOwed, date);
            sc.ShowDialog();
        }
    }
}
