using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Calculations
{
    public class Calculator
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
