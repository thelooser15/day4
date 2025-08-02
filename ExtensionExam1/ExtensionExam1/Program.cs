using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers to perform the operation");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Calculation c = new Calculation();
            Console.WriteLine(c.Sum(a, b));
            Console.WriteLine(c.Sub(a, b));
            Console.WriteLine(c.Mult(a,b));
            Console.WriteLine(c.Div(a,b));


        }
    }
}
