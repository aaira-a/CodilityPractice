
using Xunit;

namespace Equi.Tests
{
    public class XUnitSmokeTests
    {
        [Fact]
        public void TestAdd_WithTwoIntegers_ReturnsAnInteger()
        {
            var result = XUnitSmoke.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
