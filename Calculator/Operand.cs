using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operand
    {
        public decimal Number { get; set; }

        public Operand(decimal value)
        {
            this.Number = value;
        }
    }
}
