using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    public partial class Calcii
    {
        public Calcii()
        {
            Console.WriteLine("Constructor called");
            Console.Read();
        }

       public partial void add(int a, int b)
        {
            Console.WriteLine(a + ", " + b);
            Console.WriteLine(x);


        }
       public void mul(int a, int b)
        {
            Console.Write(a * b);
        }

    }
}
