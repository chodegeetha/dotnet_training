using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Create a C# program that requests three names of people from the user and stores them in an array of objects of type Person.
//To do this, first create a Person class that has a Name property of type /string and override the ToString() method.

namespace practice2
{


    class Person
    {
        public String Name { get; set; }
        public Person(String name)
        {
            Name = name;
        }
        public override String ToString()
        {
            return $"Hello, My name is {Name}";
        }
        ~Person()
        {
            Console.WriteLine("Destructor Called"); ///destructor usage
            Name=String.Empty ;
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                persons.Add(new Person(name));

            }
            foreach (var i in persons)
            {
                Console.WriteLine(i.ToString());
            }
            //Console.ReadLine();
        }
    }
}
  
   
 