using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal1
{
    public class CalBOL
    {
        public int Result { get; set; }

        public void Add(int num1,int num2)
        {
            Result = num1 + num2;
        }
        public void Sub(int num1, int num2)
        {
            Result = num1 - num2;

        }
        public void Mul(int num1, int num2)
        {
            Result = num1 * num2;
        }
        public void Div(int num1, int num2)
        {
            Result = num1 / num2;
        }
    }
}
