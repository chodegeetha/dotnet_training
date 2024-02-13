using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics

{
    class program { 
    public bool Compare<T>(T a, T b)
    {
        if (a.Equals(b)){
                return true;
        }
        return false;
    }
    
        static void Main(string[] args)
        {
            program x = new program();
            bool y = x.Compare<float>(12.45f, 12.35f);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
