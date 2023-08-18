namespace HomeWorkMiniProjectUnitTests.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void addShouldReturnlessthan100()
        {
            Calculator calculator = new();

            double expected = calculator.Add(39, 60);

            Assert.True(expected < 100);
        }
        [Fact]
        public void AddShouldReturn2()
        {
            Calculator calculator = new();

            double expected = 2;
            double actual = calculator.Add(1, 1);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, 100, 2501)]
        [InlineData(25, 100, 2500)]
        [InlineData(25, 100, 2499)]
        [InlineData(25, 99, 2475)]
        [InlineData(25, 10, 250)]


        public void MultiplyShouldReturnCorrectMultiplication(double num1, double num2, double expected)
        {
            Calculator calculator = new();

            double actual = calculator.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}
