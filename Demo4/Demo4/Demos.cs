using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///
/// the use of static variable 
/// </summary>
namespace Demo4
{
    //internal class Demos
    //{
    //    int count;
    //    public void Increment()
    //    {
    //        count++;
    //    }
    //    public void show()
    //    {
    //        Console.WriteLine("count is " + count);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Demos d1 = new Demos();
    //        Demos d2 = new Demos();
    //        d1.Increment();
    //        d1.show();//here the output will be count is 1
    //        d2.Increment();
    //        d2.show();// here the output will be count is 1 
    //        // this is because the foe every new object it will call again the count value as zero 

    //        //by using the static keyword the output will change 
    //        // static varaible will retains values irresepective of type of object.


    //    }
    //}
    internal class Demos
    {
        static int count;// static variable 
        public void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("count is " + count);
        }
        static void Main(string[] args)
        {
            Demos d1 = new Demos();
            Demos d2 = new Demos();
            d1.Increment();
            d1.Show();//here the output will be count is 1
            d2.Increment();
            d2.Show();// here the output will be count is 2
            // this time it is because of we used the static keyword
        }
    }
}
