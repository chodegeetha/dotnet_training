using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("physics", 89);
            ht.Add("Maths", 73);
            ht.Add("Telugu", 80);
            ht.Add("English", 65);
            ht.Add("Biology", 70);
            ht.Add("Social", 98);
            Console.WriteLine(ht["maths"]);
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key+ " "+ht[key]);

            }
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key);

            }
            int c = ht.Count;
            bool d = ht.IsFixedSize;
            bool e = ht.IsReadOnly;
            ICollection keys = ht.Keys;     //to see which collection they present
            ICollection values = ht.Values;
            Console.WriteLine(c+ " "+d+" "+e+" "+keys+" "+values);
            ht.Add("history", 56);
            PrintHashtable(ht);

            ht.Remove("maths");
            PrintHashtable(ht);
            Hashtable copy = (Hashtable)ht.Clone();  //creates a copy of present hashtable



            Console.WriteLine("Social".GetHashCode()); //using of hashcode they fetch the values in hashtable
            Console.ReadLine();

        }
        static void PrintHashtable(Hashtable ht)
        {
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key + " " + ht[key]);

            }
        }
    }
}
