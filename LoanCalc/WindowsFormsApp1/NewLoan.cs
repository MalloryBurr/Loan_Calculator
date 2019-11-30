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
    public partial class NewLoan : Form
    {
        public NewLoan()
        {
            InitializeComponent();
        }

        private void universityInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.universityInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loanCalcDatabaseDataSet);
        }

        private void NewLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loanCalcDatabaseDataSet.UniversityInfo' table. You can move, or remove it, as needed.
            //this.universityInfoTableAdapter.Fill(this.loanCalcDatabaseDataSet.UniversityInfo);
        }

        private static readonly int numberOfYears;

        private double amountOwed;
        private double interest;

        private void button1_Click(object sender, EventArgs e)
        {
            string universityName = Convert.ToString(uniName.Text);
            double numberOfCreditHours = Convert.ToDouble(textBox2.Text);
            double costperch = Convert.ToDouble(textBox3.Text);
            interest = Convert.ToDouble(textBox4.Text);
            double duration = Convert.ToDouble(textBox6.Text);

            amountOwed = numberOfCreditHours * costperch;
            
                //what is new amount supposed to be used for? -JM
            double newamount = 0;
            //commented out this because it sends the wrong parameters-JM
            // double final = monthlypayrate(costperch, duration, interest, newamount);
            textMonthlyPayments.Text = monthlypayrate(costperch, duration, interest, numberOfCreditHours).ToString("f2");
            double final = (monthlypayrate(costperch, duration, interest, numberOfCreditHours) *(duration*12));
            textBox5.Text = final.ToString("f2");

        }

        public static double monthlypayrate(double costPerCh, double duration, double interest, double numberOfCH)
        {
            double loanAmount;
            double credithours = numberOfCH;
            double costpercredithours = costPerCh;
            loanAmount = credithours * costpercredithours;
            double rateOfInterest = interest / 1200;
            //changed from numberOfYears to duration. number of years is never set to anything so is always 0 and is not needed 
            // because duration already exists-JM
            double numberOfPayments = duration * 12;
            double paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));
            return (paymentAmount);
        }

        private void textPaymentOptions_Click(object sender, EventArgs e)
        {
            PayOptions pay = new PayOptions(amountOwed, interest);
            pay.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void uniname(object sender, EventArgs e)
        {

        }

        private void credithours(object sender, EventArgs e)
        {

        }

        private void costpercredithours(object sender, EventArgs e)
        {

        }

        private void intrate(object sender, EventArgs e)
        {

        }

        private void durationiyears(object sender, EventArgs e)
        {

        }


        private void uniName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
