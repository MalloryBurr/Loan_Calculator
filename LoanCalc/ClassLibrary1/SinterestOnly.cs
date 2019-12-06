using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Xunit;
using WindowsFormsApp1;
namespace ClassLibrary1
{
    public class SinterestOnly
    {
        [Fact]

        public void ShouldbeInterestOnly()
        {
            double expected = 100;
            double final = ExistingLoan.InterestOnly(90, 10);
            Assert.Equal(expected, final);
        }

    }
}
