using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalc_GUI
{
    public partial class newLoan : UserControl
    {
        public newLoan()
        {
            InitializeComponent();
        }

        private void uniInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uniInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loanCalcDBDataSet);

        }
    }
}
