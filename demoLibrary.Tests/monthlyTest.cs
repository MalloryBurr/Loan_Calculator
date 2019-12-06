using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoLibrary;
using WindowsFormsApp1;
using Xunit;

namespace demoLibrary.Tests
{
    public class monthlyTest
    {
        [Fact]
        public void monthlyPayment_shouldGenerateCorrectMonthlyPayment()
        {
            //arrange
            double expectedMonthlyPayment = 202.74;

            //act
            double actualMonthlyPayment = PayOptions.monthlyPayment(9999,60,8); 

            //assert

            Assert.Equal(expectedMonthlyPayment, actualMonthlyPayment);
        }
    }
}
