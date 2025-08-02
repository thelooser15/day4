using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;
namespace ExtensionExam2
{
    internal static class MisiingDetails
    {
        public static string College(this Operations op)
        {
            return "Im from AAAABC";

        }
        public static string Numm(this Operations op)
        {
            return "+919876543210";
            
        }
    }
}
