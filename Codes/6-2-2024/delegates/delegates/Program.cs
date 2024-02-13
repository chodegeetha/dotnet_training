using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void MyDelegate(int x, int y);

    public class Calculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate del = new MyDelegate(calc.Add);
            del(10, 20);
            Console.ReadLine();
        }
    }
}
