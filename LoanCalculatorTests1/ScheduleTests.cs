using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class ScheduleTests
    {
        [TestMethod()]
        public void setDurationTest()
        {
            //expected
            int expected = 13;

            //actual
            int actual = WindowsFormsApp1.Schedule.setDuration("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void roundTotalTest()
        {
            //expected
            double expected = 1.33;

            //actual
            double actual = WindowsFormsApp1.Schedule.roundTotal(1.3333);

            Assert.AreEqual(expected, actual);
        }
    }
}