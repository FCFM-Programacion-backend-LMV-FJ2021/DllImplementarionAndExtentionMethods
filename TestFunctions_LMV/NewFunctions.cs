using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFunctionsDWB_LMV;

namespace TestFunctions_LMV
{
    public static class NewFunctions
    {
        public static decimal Div(this Functions fn, decimal a, decimal b)
        {
            return a / b;
        }

        public static decimal Resta(this Functions funct, decimal a, decimal b)
        {
            return a - b;
        }
    }
}
