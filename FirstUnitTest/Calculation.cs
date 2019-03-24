using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnitTest
{
    public class Calculation
    {
        public int Add(int inputA, int inputB)
        {
            return inputA + inputB;
        }

        public int Multiple(int inputA, int inputB)
        {
            return inputA * inputB;
        }

        public int Divide(int inputA, int inputB)
        {
            if (inputB == 0)
            {
                throw new DivideByZeroException("input B should have value");
            }
            else
            {
                return inputA / (inputB);
            }

        }
    }
}
