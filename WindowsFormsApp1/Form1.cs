// Mallory Burr, Joe Martinez
// all database file Mallory Burr
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // links to the new loan display 
        private void newLoanButton_Click(object sender, EventArgs e)
        {
            NewLoan nl = new NewLoan();
            nl.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loanCalcDatabaseDataSet.UniversityInfo' table. You can move, or remove it, as needed.
            //this.universityInfoTableAdapter.Fill(this.loanCalcDatabaseDataSet.UniversityInfo);

        }

        // links to the existing loan display
        private void existingLoanButton_Click(object sender, EventArgs e)
        {
            ExistingLoan el = new ExistingLoan();
            el.ShowDialog();
        }
    }
}

