using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting_examples
{


    class Program
    {
        static void Main()
        {
            // Implicit Casting (Widening)
            int intValue = 10;
            double doubleValue = intValue; // Implicit casting from int to double
            Console.WriteLine($"Implicit Casting (Widening): int to double - Original: {intValue}, Converted: {doubleValue}");

            // Explicit Casting (Narrowing)
            double doubleValue2 = 15.75;
            int intValue2 = (int)doubleValue2; // Explicit casting from double to int
            Console.WriteLine($"Explicit Casting (Narrowing): double to int - Original: {doubleValue2}, Converted: {intValue2}");

            // Boxing
            int boxedInt = 42;
            object boxedObject = boxedInt; // Boxing - Implicit conversion to object
            Console.WriteLine($"Boxing: int to object - Original: {boxedInt}, Boxed: {boxedObject}");

            // Unboxing
            float unboxedInt = (int)boxedObject; // Unboxing - Explicit conversion from object to int
            Console.WriteLine($"Unboxing: object to int - Original: {boxedObject}, Unboxed: {unboxedInt}");
            Console.ReadLine();
        }
    }
}

            
    
