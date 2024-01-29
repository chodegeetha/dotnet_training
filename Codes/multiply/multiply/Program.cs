using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arthimeticcalci;

namespace multiply
{
    internal class Program
    {
         public static void Main(string[] args)
        {
            arthimeticcalci.Class1 cl=new arthimeticcalci.Class1();
            Console.WriteLine(cl.mul(10, 20));
            Console.WriteLine(cl.div(10, 5));
            Console.ReadLine();
        }
    }
}
