using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class CalculatorResult
    {
        internal decimal Result { get; set; }
        internal bool IsSucces { get; set; }
        internal string ErrorMessage { get; set; }
    }
}
