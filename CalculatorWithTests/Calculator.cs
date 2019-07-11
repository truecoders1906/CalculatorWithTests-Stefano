using System;
using System.Linq;

namespace CalculatorWithTests
{
    public class Calculator
    {
        public decimal GetSum(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public decimal GetDifference(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public decimal GetResults(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public decimal GetQuotient(decimal number1, decimal number2)
        {
            if (number2 == 0)
            {
                return 0;
            }
            return number1 / number2;
        }

        public int GetFactorial(int number)
        {

            int results = 1;

            for (int i = number; i >= 1; i--)
            {
                results *= i;
            }
            return results;
        }     
    }
}
