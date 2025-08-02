using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    static class Demo
    {
        public static void Show()
        {
            Console.WriteLine("Show method from demo class");
        }
        public static string Pavan()
        {
            return "my name is pavan kumar";
        }

    }
    /// <summary>
    /// for the static class it contains only static methods
    ///  for the static class we cannot create a object to it
    /// </summary>
    internal class StarticClassEx
    {
        static void Main()
        {
            Demo.Show();
            Console.WriteLine(Demo.Pavan());
        }
    }
}
