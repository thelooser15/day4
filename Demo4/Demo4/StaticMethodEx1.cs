using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Data
    {
        public void Show()
        {
            Console.WriteLine("this is the show method from class data");

        }
        public static void Display()
        {
            Console.WriteLine("Display method from class Data");
        }
    }
    internal class StaticMethodEx1
    {
        static void Main()
        {
            Data.Display();
            new Data().Show();
        }
    }
}
