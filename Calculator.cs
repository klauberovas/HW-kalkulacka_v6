using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_kalkulacka_v6
{
    internal class Calculator
    {
        private double ActualResult = 0;
        //--------------------------------------
        private static readonly string[] ValidOperators = { "+", "-", "*", "/", "^" };

        public bool isValidOperator(string mathOperator)
        {
            return ValidOperators.Contains(mathOperator);
        }

        public double SumUp(double value)
        {
            return ActualResult += value;
        }
        public double Subtract(double value)
        {
            return ActualResult -= value;
        }
        public double Multiply(double value)
        {
            return ActualResult *= value;
        }
        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Nemůžeš dělit 0.");
            }
            return ActualResult /= divisor;
        }
        public double Power(int exponent)
        {

            if (exponent == 0)
            {
                return 1;
            }

            if (ActualResult == 0 && exponent < 0)
            {
                throw new DivideByZeroException("Cannot raise zero to a negative exponent.");
            }

            double result = 1;
            int absExponent = Math.Abs(exponent);

            for (int i = 0; i < absExponent; i++)
            {
                result *= ActualResult;
            }

            ActualResult = exponent > 0 ? result : (1 / result);
            return ActualResult;
        }

        public  double GetCurrentResult()
        {
            return ActualResult;
        }
    }
}
