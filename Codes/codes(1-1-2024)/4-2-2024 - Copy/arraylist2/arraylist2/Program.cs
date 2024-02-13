using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ArrayList al = new ArrayList();
            List<int> list = new List<int> { 1, 6, 8, 9 };
            Console.WriteLine(al.Capacity);
            al.Add(100);
            al.Add(300);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            al.Add(600);
            al.Add(700);
            al.Add(800);
            Console.WriteLine(al.Capacity);//the capacity becomes double  it gives 4 for first value after filling 4 values it will give 8(4before+4after) capacity 
            al.Insert(3, 350);
            al.RemoveAt(1); // giving only index
           printArray(al);
            al.Remove(600);
            printArray(al);
            Console.WriteLine();
            object[] b = al.ToArray();
            //arraylist to array and it storing values in obj only bcz it has variable datatypes
           
            foreach(int i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            al.AddRange(list);
            //adding another collection to array

            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(al.Capacity);
            int index = al.IndexOf(500);
            Console.WriteLine(index);
            Console.WriteLine();
            al.TrimToSize();                    // It will trim the  dynamicsize  to the actualsize of ourelements
            Console.WriteLine(al.Capacity);


            Console.ReadLine();
            

        }
        static void printArray(ArrayList al)
        {
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
            
        }

    }
}
