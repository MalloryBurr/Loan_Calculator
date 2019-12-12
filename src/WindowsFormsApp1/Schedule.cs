// Mallory Burr
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
    public partial class Schedule : Form
    {
        public Schedule(string duration, double totalOwed, DateTime date)
        {
            // parsing to an int 
            int timePeriod = 1 + Int32.Parse(duration) * 12;
            InitializeComponent();


            ScheduleDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter = new ScheduleDataSetTableAdapters.ScheduleTableAdapter();

            double monthlyPayment = Math.Round((totalOwed / timePeriod), 2);
            totalOwed = Math.Round(totalOwed, 2);


            for (int i = 0; i <= timePeriod; ++i)
            {
                // date, payment, amount remaining
                scheduleTableAdapter.Insert(date.ToShortDateString(), monthlyPayment, totalOwed);
                totalOwed = Math.Round((totalOwed - monthlyPayment), 2);
                date = date.AddMonths(1);
            }
            
            
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.scheduleDataSet.Schedule);            
        }
    }
}
