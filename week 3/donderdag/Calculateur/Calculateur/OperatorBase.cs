using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    abstract class OperatorBase
    {
        abstract public String symbol { get; set; }

        public abstract double calculate(String textA, String textB);
    }
}
