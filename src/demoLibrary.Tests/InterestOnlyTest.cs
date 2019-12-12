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
    public class InterestOnlyTest
    {
        [Fact]
        public void monthlyPayment_shouldGenerateCorrectMonthlyPayment()
        {
            //arrange
            double InterestOnlyValue = 500.00;

            //act
            double InitialMinusFinal = ExistingLoan.InterestOnly(1000.00,500.00); 

            //assert

            Assert.Equal(InterestOnlyValue, InitialMinusFinal);
        }
    }
}
