using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflection
{

    public class MyClass
    {
        public int MyProperty { get; set; }
        public void MyMethod() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TO Get the type of MyClass
            Type type = typeof(MyClass);


            Console.WriteLine($"Type: {type.FullName}");

            // To Get all properties of MyClass
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine($"Properties:");
            foreach (var property in properties)
            {
                Console.WriteLine($"- {property.Name} ({property.PropertyType.FullName})");
            }

            // To Get all methods of MyClass
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine($"Methods:");
            foreach (var method in methods)
            {
                Console.WriteLine($"- {method.Name}");
            }
            Console.ReadLine();
        }
    }
}
