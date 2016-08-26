using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NXNCPR_X72_1.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_12_returns_21()
        {
            var result = Solution.solution(12);
            Assert.Equal(21, result);
        }

        [Fact]
        public void Test_122_returns_221()
        {
            var result = Solution.solution(122);
            Assert.Equal(221, result);
        }
    }
}
