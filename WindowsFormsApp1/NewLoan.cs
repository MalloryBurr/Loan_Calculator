// Joe Martinez, Mallory Burr, Asia Dahmas
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
            this.universityInfoTableAdapter.Fill(this.loanCalcDatabaseDataSet.UniversityInfo);
        }

        //create global values to pass through methods
        private double amountOwed;
        private double interest;

        // initilizes variables based on user input
        private void calcButton_Click(object sender, EventArgs e)
        {

            string universityName = Convert.ToString(uniName.Text);
            double numberOfCreditHours = Convert.ToDouble(textBox2.Text);
            double costperch = Convert.ToDouble(textBox3.Text);
            interest = Convert.ToDouble(textBox4.Text);
            double duration = Convert.ToDouble(textBox6.Text);

            //calculate amount owed on loan
            amountOwed = numberOfCreditHours * costperch;
            
            //assign values and calculate final
            textMonthlyPayments.Text = monthlypayrate(costperch, duration, interest, numberOfCreditHours).ToString("f2");
            double final = (monthlypayrate(costperch, duration, interest, numberOfCreditHours) *(duration*12));
            textBox5.Text = final.ToString("f2");

        }

        //calculate monthly payments and assign to variables
        public static double monthlypayrate(double costPerCh, double duration, double interest, double numberOfCH)
        {
            double loanAmount;
            double credithours = numberOfCH;
            double costpercredithours = costPerCh;
            loanAmount = credithours * costpercredithours;
            // calculates the monthly pay rate for the inputted loan
            double rateOfInterest = interest / 1200;
            double numberOfPayments = duration * 12;
            double paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));
            return (paymentAmount);
        }
        //call Pay Options and display window
        private void textPaymentOptions_Click(object sender, EventArgs e)
        {
            
            PayOptions pay = new PayOptions(amountOwed, interest);
            pay.ShowDialog();
        }
        
    }
}
