
using Xunit;

namespace Equi.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void ThreeElements_withMiddleIndex_returnsIndex1()
        {
            var result = Solution.solution(new int[]{5, 2, 5});
            Assert.Equal(1, result);
        }
    }
}
