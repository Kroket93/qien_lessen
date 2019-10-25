using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    class operatorDivision : OperatorBase
    {
        public override String symbol
        {
            get { return "/"; }
            set { }
        }
        public override double calculate(String textA, String textB)
        {
            return Convert.ToDouble(textA) / Convert.ToDouble(textB);

        }
    }
}