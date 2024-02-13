using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalnamed_parameters
{
    internal class Program
    {
       
         static void details(string name, int age, string city)
         {
                Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
         }
        static void Greetings(string name, string greeting = "Hello")//optional hello
        {
                Console.WriteLine($"{greeting}, {name}!");
        }

        static void Main()
        {
                // Using named parameters
                 details(age: 25, name: "John", city: "New York");
                 Greetings("geetha", "hi");
                 Greetings(name: "jyothi"); // Using named &optional parameters
                  Console.ReadLine();
                 
        }
        

    }
}
