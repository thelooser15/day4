using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train[] arrTraining = new Train[]
            {
                new Pavan(),
                new Harsha()
            };

            foreach(Train t in arrTraining)
            {
                t.College();
                t.Name();
                t.Age();
            }
        }
    }
}
