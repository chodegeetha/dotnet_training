using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethods
{
   
        public static class stringextensions
        {
            public static string  concatenate(this string x1,string x2)
            {
                return x1 + x2;
            }
        }

    class program
    {
        public static void Main(string[] args)
        {
            String a = "hello";
            String b = "world";
            String x = a.concatenate(b);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
    
}
