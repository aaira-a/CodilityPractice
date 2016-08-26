using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NXNCPR_X72_2.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_28_returns_7()
        {
            var binaryString = Convert.ToString(28, 2);
            var result = Solution.solution(binaryString);
            Assert.Equal(7, result);
        }
    }
}
