using Xunit;

namespace HelloWorld
{
    public class ClassTests
    {
        [Fact]
        public void ReturnNumber_returns_number()
        {
            Assert.Equal(42, new Class().ReturnNumber(42));
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        public void ReturnNumber_returns_number(int number)
        {
            Assert.Equal(number, new Class().ReturnNumber(number));
        }

        [Fact(Skip = "ABC")]
        public void ReturnNumber_returns_number_failing()
        {
            Assert.Equal(0, new Class().ReturnNumber(42));
        }

    }
}