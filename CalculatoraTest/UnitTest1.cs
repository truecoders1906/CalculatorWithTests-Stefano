using System;
using Xunit;
using CalculatorWithTests;


namespace CalculatoraTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, -5, 0)]
        [InlineData(2.5, 2.5, 5)]
        [InlineData(10, -2.5, 7.5)]
        [InlineData(-10, -10, -20)]
        [InlineData(10, 10, 20)]
        [InlineData(100, 1000, 1100)]
        public void ShouldCalculateSum(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            decimal actual = Calc.GetSum(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, -5, 10)]
        [InlineData(2.5, 2.5, 0)]
        [InlineData(10, -2.5, 12.5)]
        [InlineData(-10, -10, 0)]
        [InlineData(10, 10, 0)]
        [InlineData(1100, 1000, 100)]
        public void ShouldCalculateDifference(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            decimal actual = Calc.GetDifference(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(5, -5, -25)]
        [InlineData(2.5, 2.5, 6.25)]
        [InlineData(10, -2.5, -25)]
        [InlineData(-10, -10, 100)]
        [InlineData(10, 10, 100)]
        [InlineData(1100, 1000, 1100000)]
        public void ShouldCalculateResults(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            decimal actual = Calc.GetResults(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, -5, -1)]
        [InlineData(2.5, 2.5, 1)]
        [InlineData(10, -2.5, -4)]
        [InlineData(-10, -10, 1)]
        [InlineData(-100, 10, -10)]
        [InlineData(1100, 1000, 1.1)]
        public void ShouldCalculateQuotient(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            decimal actual = Calc.GetQuotient(number1, number2);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        [InlineData(8, 40320)]
        [InlineData(10, 3628800)]
        public void ShouldCalculateFactorial(int number, int expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            int actual = Calc.GetFactorial(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
