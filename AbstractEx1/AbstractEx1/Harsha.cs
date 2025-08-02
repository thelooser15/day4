using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx1
{
    internal class Harsha:Train
    {
        public override void Name()
        {
            Console.WriteLine("my name is Harsha");
        }
        public override void Age()
        {
            Console.WriteLine("your age is 23");

        }
        public override void Mail()
        {
            Console.WriteLine("your maail id is: Harsha@gmail.com");
        }
    }
}
