 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
   public static class Calculate
    {
        public static double DoCalculation (double vall, double va12, string operatorMath)
        {
            double result = 0;

            switch (operatorMath)
            {
                case "/":
                    result = vall / va12; 
                    break;
                case "-":
                    result = vall / va12;
                    break;
                case "+":
                    result = vall / va12;
                    break;
                case "*":
                    result = vall / va12;
                    break;

            }
            return result;
        }

    }
}
