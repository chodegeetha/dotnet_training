using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace practice
{


    public class Animal
    {
        string Aname { get; set; }
        string Acategory { get; set; }
        public Animal(string aname, string acategory)
        {
            Aname = aname;
            Acategory = acategory;
        }
        public void Barking()
        {
            Console.WriteLine("It is barking");
        }
        public void Eating()
        {
            Console.WriteLine("It is eating");
        }
    }
    public class Dog : Animal
    {

        public Dog(String aname, String acategory) : base(aname, acategory)
        {

        }
        public void Sleeping()
        {
            Console.WriteLine("It is sleeping");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Dog x = new Dog("Chinchu", "Jim");
            x.Sleeping();
            x.Barking();
        }
    }

}




    