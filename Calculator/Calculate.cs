using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public static decimal Add(Operand l, Operand r)
        {
            return l.Number + r.Number;
        }

        public static decimal Subtract(Operand l, Operand r)
        {
            return l.Number - r.Number;
        }

        public static decimal Multiply(Operand l, Operand r)
        {
            return l.Number * r.Number;
        }

        public static decimal Divide(Operand l, Operand r)
        {
            return l.Number / r.Number;
        } 
    }
}
