using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection2
{

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Calculator calculator = new Calculator();

           
            Type type = calculator.GetType();

            
            MethodInfo addMethod = type.GetMethod("Add");

            
            object[] arguments = { 10, 20 };

            // Invoke the "Add" method dynamically
            int result = (int)addMethod.Invoke(calculator, arguments);
            Console.WriteLine($"Result of Add method: {result}");

            
            MethodInfo multiplyMethod = type.GetMethod("Multiply");

           
            object[] argumentsMultiply = { 3.5, 2.5 };

            // Invoke the "Multiply" method dynamically
            double resultMultiply = (double)multiplyMethod.Invoke(calculator, argumentsMultiply);
            Console.WriteLine($"Result of Multiply method: {resultMultiply}");
            Console.ReadLine();
        }
    }
}
