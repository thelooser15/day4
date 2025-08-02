using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExtensionLibrary;

namespace ExtensionExam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations op=new Operations();
            Console.WriteLine(op.Name());
            Console.WriteLine(op.Address());
            Console.WriteLine(op.College());
            Console.WriteLine(op.Numm());

        }
    }
}
