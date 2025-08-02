using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx1
{
    internal abstract class Train
    {
        public void College()
        {
            Console.WriteLine("Your college name is JNTUH");
        }
        public abstract void Name();
        public abstract void Age();

        public abstract void Mail();
    }
}
