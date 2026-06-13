using Xunit;
using MyWebApp;

namespace MyWebApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange: set up the tools and the expected answer
            var calculator = new Calculator();
            int expected = 5;

            // Act: actually run the thing we're testing
            int result = calculator.Add(2, 3);

            // Assert: check reality matches what we expected
            Assert.Equal(expected, result);
        }
    }
}