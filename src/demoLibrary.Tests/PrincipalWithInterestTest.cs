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
    public class PrincipalWithInterestTest
    {
        [Fact]
        public void principalWithInterest_shouldGenerateCorrectInterest()
        {

            //arrange
            double TotalTestValue = 15060;

            //act
            double MonthlyTimesLoanDuration = ExistingLoan.principalWithInterest(251, 60);

            //assert
            Assert.Equal(TotalTestValue, MonthlyTimesLoanDuration);
        }
    }
}
