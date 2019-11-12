using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalc_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // New loan button
        private void button1_Click(object sender, EventArgs e)
        {
            //hide other panels and user control windows
            existingLoan1.Hide();
            button1.Hide();
            button2.Hide();
            //show selected user control
            newLoan1.Show();
            newLoan1.BringToFront();
            

        }

        // Existing loan button
        private void button2_Click(object sender, EventArgs e)
        {
            //hide other panels and user control windows
            newLoan1.Hide();
            button1.Hide();
            button2.Hide();
            
            //show selected user control
            existingLoan1.Show();
            existingLoan1.BringToFront();
           
        }

        // button that brings you back to the home page
        private void button3_Click(object sender, EventArgs e)
        {
            newLoan1.Hide();
            existingLoan1.Hide();
            button1.Show();
            button2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newLoan1.Hide();
            existingLoan1.Hide();
            
        }

        private void existingLoan1_Load(object sender, EventArgs e)
        {

        }

        private void newLoan1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
