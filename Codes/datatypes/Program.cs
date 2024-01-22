using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Value
    {
        static void Main(string[] args)
        {

            int a = -2589000;
            uint b = 25890;
            char c = '\u0042';
            float d = -43.27F; //f is compulsory
            double e = -11092.53;
            decimal f = -53005.25m;
            char g = (char)69;// casted from integer
            double h = 6.21e2;// equivalent to 6.21 x 102 i.e. 621
            char i = '\x0072';// hexadecimal
            int j = 0x11c;// decimal value 284
            long k = -10928190L;
            ulong l = 17091821871; //l is default
            short m = -1109;
            bool n = true;
            ushort o = 42019;
            byte p = 9;
            sbyte q = -124;
            var r = false;

            dynamic z;

            object t = q;
            z = t;
            uint u = (uint)m;
            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e + "\n" + f + "\n" + g + "\n" + h + "\n" + i + "\n" + j + "\n" + k + "\n" + l + "\n" + m + "\n" + n + "\n" + o + "\n" + p + "\n" + q + "\n");
            Console.WriteLine(z + "\n" + t + "\n" + r + "\n" + u);



            Console.WriteLine("hello");


        }
    }
}
