using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExam1
{
    internal static class Extension
    {
        public static int Mult(this Calculation calc,int a , int b)
        {
            return a * b;

        }
        public static int Div(this Calculation calc, int a , int b) { return a / b; }

    }
}
