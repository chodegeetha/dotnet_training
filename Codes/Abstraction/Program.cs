using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class A
    {
        public int x, y;
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract int m1(String a);
        public double m2(int b)
        {
            Console.WriteLine("hello");
            return 50;

        }

    }
    public class B : A
    {
        public override int m1(string a)
        {

            Console.WriteLine(a);
            return 10;
        }
        public B(int a, int b) : base(30, 40)
        {
            Console.WriteLine("hi constructor");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            B a = new B(10, 20);
            Console.WriteLine(a.m1("hi"));
            Console.WriteLine(a.m2(10));

        }
    }
}
