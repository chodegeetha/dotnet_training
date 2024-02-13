using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastdelegate
{

    public delegate double CalculateAreaDelegate(double radius);

    public class Circle
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }

    public class Square
    {
        public double CalculateArea(double side)
        {
            return side * side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle();
            Square square = new Square();
            CalculateAreaDelegate del = circle.CalculateArea;
            del += square.CalculateArea; //Multicast delegate by using += operator
            double radius = 5;
            double side = 4;
            Console.WriteLine("Area of Circle: " + del(radius));
            Console.WriteLine("Area of Square: " + del(side));
            Console.ReadLine();
        }
    }
}

