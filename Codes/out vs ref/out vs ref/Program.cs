using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_vs_ref
{
    internal class Program
    {
        
        static void refValues(ref int a, ref int b)
        {
            /*a = 10;
            b = 20;*/
            Console.WriteLine(a + ", " + b);/*here o/p-10,20*/

            a = 70;
            b = 30;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            refValues(ref x, ref y);    
            Console.WriteLine(x + " " + y); /*Output is 70,30 modified value but it takes 10,20 at start*/
            Console.ReadLine();
        }
    }
}
