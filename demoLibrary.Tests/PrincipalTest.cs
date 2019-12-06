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
    public class PrincipalTest
    {
        [Fact]
        public void principalWithInterest_shouldGenerateCorrectInterest()
        {

            //arrange
            double expectedTotalLoan = 12748.20;

            //act
            double actualTotalLoan = PayOptions.principalWithInterest(212.47, 60);

            //assert
            Assert.Equal(expectedTotalLoan, actualTotalLoan);
        }
    }
}
