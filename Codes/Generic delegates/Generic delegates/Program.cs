using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_delegates
{
    /*public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate double Delegate3(string str);*/

    class GenericDelegates
    {
        public static double add(int x,float y,double z)
        {
            return x+y + z;
        }
        public static void add2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(String str)
        {
            if (str.Length > 3)
            {
                return false;
            }
            return true;
        }

    
        static void Main(string[] args)
        {
            Func<int,float,double,double> dl1 = add;
            double result = dl1(100, 14.5f, 196.45);
            Action<int,float,double> dl2 = add2;
            dl2(100, 12.4f, 123.67);
            Console.WriteLine(result);
            Predicate<string> dl3 = CheckLength;
            bool x = dl3("hello");
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
