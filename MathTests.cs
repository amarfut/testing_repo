using Xunit;

namespace Tests
{
    public class MathTests
    {
        [Fact]
        public void Divide_DividerIsZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Math.Divide(41, 0));
        }
    }
}
