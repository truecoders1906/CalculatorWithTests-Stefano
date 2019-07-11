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
        [InlineData(-10, -10, 7.5)]
        [InlineData(10, 10, 20)]
        [InlineData(100, 1000, 1100)]
        public void ShouldCalculateSum(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            decimal actual = Calc.GetSum();

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
            decimal actual = Calc.GetDifference();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(5, -5, -25)]
        [InlineData(2.5, 2.5, 6.26)]
        [InlineData(10, -2.5, -25)]
        [InlineData(-10, -10, 100)]
        [InlineData(10, 10, 100)]
        [InlineData(1100, 1000, 10000)]
        public void ShouldCalculateResults(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator Calc = new Calculator();

            // Act
            decimal actual = Calc.GetResults();

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
            decimal actual = Calc.GetQuotient();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
