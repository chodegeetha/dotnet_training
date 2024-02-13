using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{



    

    class Program
    {
        static void Main()
        {
            // Nullable int
            int? nullableInt = null;

            // Nullable double
            double? nullableDouble = 3.14;

            // Nullable bool
            bool? nullableBool = true;

            // Nullable DateTime
            DateTime? nullableDateTime = DateTime.Now;

            // Display values or "null" if they are null
            Console.WriteLine($"Nullable Int: {nullableInt ?? 11}");
            Console.WriteLine($"Nullable Double: {nullableDouble ?? -1.0}");
            Console.WriteLine($"Nullable Bool: {nullableBool ?? false}");
            Console.WriteLine($"Nullable DateTime: {nullableDateTime ?? DateTime.MinValue}");
            Console.ReadLine();
        }
    }
}
