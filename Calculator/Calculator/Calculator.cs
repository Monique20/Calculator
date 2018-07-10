using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorKata
{
    public class Calculator
    {
        public int Calculate(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            return 2;
        }
    }
}
