using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterators
{
    class IteratorExample
    {
        public static IEnumerable<string> GetList()
        {

            List<string> list = new List<string> { "geetha", "shyam", "Ram", "Jashu" };


            foreach (var i in list)
            {
                yield return i;
            }
        }
        public static IEnumerator<string> Getlist2()
        {

            List<string> list = new List<string> { "hii", "hello", "Raj", "welcome" };


            IEnumerator<string> e = list.GetEnumerator();
            return e;
        }



        public static void Main(string[] args)
        {

            IEnumerable<string> elements = GetList();
            
            foreach (var j in elements)
            {
                Console.WriteLine(j);

            }

            IEnumerator<string> enumerator = Getlist2();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            

            Console.ReadLine();
        }
    }
}

