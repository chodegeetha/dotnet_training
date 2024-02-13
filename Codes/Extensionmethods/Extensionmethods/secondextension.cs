using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethods
{
    public static class Enumerableextensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            foreach (var i in collection)
            {
                sum = sum + i;
            }
            return sum;
        
        }
    }
        public class Exe
        { 
            public static void Main(string[] args)
            {
                List<int> l1 = new List<int> { 1, 2, 3, 4, 5 };
                List<float> l2 = new List<float> { 11, 12, 13 };

                Console.WriteLine($"l1sum :{l1.Sum()}");
                Console.WriteLine($"l1sum :{l2.Sum()}");
            }
            
        }
    
}
