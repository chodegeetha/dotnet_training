using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_vs_ref
{
    internal class Program
    {
        static void GetValues(out int a, out int b)
        {
            a = 10;
            b = 20;
            a = a * b;
        }
       
        static void Main(string[] args)
        {
            int x = 100, y = 30; /*output is 200,20 it is taking only initialized values in method not the values which we passed as method  */
            GetValues(out x, out y);
            Console.WriteLine(x + " " + y);
            Console.ReadLine();
        }
    }
}
