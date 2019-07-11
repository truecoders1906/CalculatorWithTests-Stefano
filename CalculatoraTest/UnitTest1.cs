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
    }
}
