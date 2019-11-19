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
    }
}
