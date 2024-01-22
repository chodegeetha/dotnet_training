// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    // Base class
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle started.");
        }


    }

    // Single Inheritance
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }

        public void Brake()
        {
            Console.WriteLine("Car is braking.");
        }
    }

    // Multilevel Inheritance
    class SportsCar : Car
    {
        public void Boost()
        {
            Console.WriteLine("Sports car is boosting.");
        }
    }

    // Hierarchical Inheritance
    class Motorcycle : Vehicle
    {
        public void Wheelie()
        {
            Console.WriteLine("Motorcycle is doing a wheelie.");
        }
    }

    // Multiple Inheritance
    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : Car, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Car is flying!");
        }
    }



    class Program
    {
        static void Main()
        {
            // Single Inheritance
            Car myCar = new Car();
            myCar.Start();
            myCar.Accelerate();


            // Multilevel Inheritance
            SportsCar mySportsCar = new SportsCar();
            mySportsCar.Start();
            mySportsCar.Accelerate();
            mySportsCar.Boost();


            // Hierarchical Inheritance
            Motorcycle myMotorcycle = new Motorcycle();
            myMotorcycle.Start();
            myMotorcycle.Wheelie();


            // Multiple Inheritance
            FlyingCar myFlyingCar = new FlyingCar();
            myFlyingCar.Start();
            myFlyingCar.Accelerate();
            myFlyingCar.Fly();



        }
    }
}


