// Mallory Burr
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: InternalsVisibleTo("UnitTests")]
namespace WindowsFormsApp1
{
    public partial class Schedule : Form
    {
        // *********************************************************
        // In this branch, and specifically in this file, I will 
        // describe how I applied the Singleton Design Pattern.
        // *********************************************************

        // This static method validated input and also is covered by a unit test
        // The return in this function helps ensure that only one instance runs,
        // per the design pattern's rules
        public static int setDuration(string durationStr)
        {
            int timePeriod = 1 + Int32.Parse(durationStr) * 12;
            return timePeriod;
        }

        // This static method validated input and also is covered by a unit test
        // The return in this function helps ensure that only one instance runs,
        // per the design pattern's rules
        public static double roundTotal(double totalOwed)
        {
            totalOwed = Math.Round(totalOwed, 2);
            return totalOwed;
        }

        // Schedule takes in informtion from the class above it, also in-line with 
        // the Singleton Design Pattern, which emphasizes this progression of information
        // in a single-instance implementation
        public Schedule(string duration, double totalOwed, DateTime date)
        {
            //call setDuration to calculate a value
            setDuration(duration);
            
            InitializeComponent();


            ScheduleDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter = new ScheduleDataSetTableAdapters.ScheduleTableAdapter();

            double monthlyPayment = Math.Round((totalOwed / setDuration(duration)), 2);
            roundTotal(totalOwed);

            
            for (int i = 0; i <= setDuration(duration); ++i)
            {
                // date, payment, amount remaining
                scheduleTableAdapter.Insert(date.ToShortDateString(), monthlyPayment, totalOwed);
                totalOwed = Math.Round((totalOwed - monthlyPayment), 2);
                date = date.AddMonths(1);
            }
        }


        public void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.scheduleDataSet.Schedule);            
        }
    }
}
