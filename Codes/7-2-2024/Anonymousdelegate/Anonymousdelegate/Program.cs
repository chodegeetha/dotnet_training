using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousdelegate
{

    public delegate string Greetingsdelegate(string name);
    class Anonymous
    {
        /* public static String Greetings(string name)
         {
             return "hello" + name + "welcome to .net";
         }*/
        static void Main(string[] args)
        {
            Greetingsdelegate dl = delegate (string name)
            {
                return "hello" + name + "welcome to .net";
            };
            String str = dl("geetha");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

