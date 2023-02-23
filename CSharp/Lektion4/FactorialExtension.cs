using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion4
{
    internal static class FactorialExtension
    {
        public static int Factorial(this int number)
        {
            int i = number;
            if (i == 1)
            {
                return i;
            }
            else
            {
                return (i - 1).Factorial() * i;
            }
        }

        public static int Power(this int number, int p)
        {
            int sum = number;
            for (int i = p - 1; i > 0; i--)
            {
                sum *= number;
            }
            return sum;
        }
    }
}
