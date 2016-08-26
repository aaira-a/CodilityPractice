
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

        [Fact]
        public void OneElement_returnsZero()
        {
            var result = Solution.solution(new int[] { 7 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void ZeroElement_returnsNegativeOne()
        {
            var result = Solution.solution(new int[] { });
            Assert.Equal(-1, result);
        }

        [Fact(Skip="skip until implemented")]
        public void ThreeElements_allZeroes_returnsIndex1()
        {
            var result = Solution.solution(new int[] { 0, 0, 0 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void ThreeElements_allOnes_returnsIndex1()
        {
            var result = Solution.solution(new int[] { 1, 1, 1 });
            Assert.Equal(1, result);
        }

        [Fact]
        public void ThreeElements_allNegativeOnes_returnsIndex1()
        {
            var result = Solution.solution(new int[] { -1, -1, -1 });
            Assert.Equal(1, result);
        }

    }
}
