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

        private static readonly int numberOfYears;


        private void button1_Click(object sender, EventArgs e)
        {
            _ = Convert.ToString(uniName.Text);
            _ = Convert.ToDouble(textBox2.Text);
            double costperch = Convert.ToDouble(textBox3.Text);
            double interest = Convert.ToDouble(textBox4.Text);
            double duration = Convert.ToDouble(textBox6.Text);
            double newamount = 0;
            double final = monthlypayrate(costperch, duration, interest, newamount);








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

        public static double monthlypayrate(double newamount, double duration, double intrate, double interest)
        {


            double loanAmount;
            double credithours = 0.0;
            double costpercredithours = 0.0;
            loanAmount = credithours * costpercredithours;
            double rateOfInterest = intrate / 1200;
            double numberOfPayments = numberOfYears * 12;
            double paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

            return (paymentAmount);
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
