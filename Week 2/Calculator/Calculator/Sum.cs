using System;

namespace Calculator
{
    public class Sum
    {
        public double GetSum(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        public double GetSum(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }
    }
}
