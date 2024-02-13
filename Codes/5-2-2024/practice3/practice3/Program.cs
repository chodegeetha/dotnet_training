using practice3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
//Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:
Person
Student
Professor
The Student and Teacher classes inherit from the Person class.
The Student class will include a public Study() method that will write I'm studying on the screen.
The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.
The Teacher class will include a public Explain() method that will write I'm explaining on the screen.
Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.
You must create another test class called StudentProfessorTest with a Main method to do the following:
Create a new Person and make him say hello
Create a new Student, set an age, say hello, and display her age on the screen.
Create a new Teacher, set an age, say hello and start the explanation.
Input
 
Output
Hello!Hello!My age is 21 years oldI'm studyingHello!I'm explaining*/



namespace practice3
{
    using System;
    class Person
    {
        protected int Age;
        public void greet()
        {
            Console.WriteLine("SAY HELLO");
        }
        public void set(int age)
        {
            Age = age;

        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine($"Iam studying");
        }
        public void Showage()
        {
            Console.WriteLine($"my age is :{Age} years old");

        }
    }
    class Professor : Person
    {
        public void explain()
        {
            Console.WriteLine($"Iam  explaining");
        }
    }
    class Testprofessor
    {
        static void Main(string[] args)
        {
            Person z = new Person();
            z.greet();
            Student x = new Student();
            x.greet();
            x.set(10);
            x.Showage();
            Professor y = new Professor();
            y.greet();
            y.set(20);
            y.explain();
            Console.ReadLine();
        }
    }
}



