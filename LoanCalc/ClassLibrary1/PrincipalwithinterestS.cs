using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using Xunit;

namespace ClassLibrary1
{
    public class PrincipalwithinterestS
    {
        [Fact]
        public void shouldbeprincipalwithinterest()
        {
            double expected = 100;
            double final = ExistingLoan.principalWithInterest(10, 10);
            Assert.Equal(expected, final);

        }
    }
}
