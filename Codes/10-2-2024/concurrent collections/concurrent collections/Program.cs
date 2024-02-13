using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concurrent_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<int, string> x = new ConcurrentDictionary<int, string>();
            x.TryAdd(1, "geethu");
            x.TryAdd(2, "jashu");
            x.TryAdd(3, "vyshu");
            x.TryAdd(3, "nikki");
            x.TryAdd(4, "akki");
            foreach (KeyValuePair<int, string> item in x)
            {
                Console.WriteLine($"key:{item.Key},value:{item.Value}");
            }

            Console.WriteLine("Is 1 Key Exists : " + x.ContainsKey(1));

            string y = string.Empty;
            bool result = x.TryRemove(3, out y);
            Console.WriteLine($"Is 3 Key Removed: {result}");
            Console.WriteLine($"Removed Value: {y}");

            bool z = x.TryUpdate(1, "lavanya", "geetha");
            foreach (KeyValuePair<int, string> item in x)
            {
                Console.WriteLine($"key:{item.Key},value:{item.Value}");
            }
            Console.WriteLine();

            x.AddOrUpdate(6, "nammu", (k, v) => "nammu Updated");
            x.AddOrUpdate(4, "akki", (k, v) => "akki Updated");
            foreach (KeyValuePair<int, string> item in x)
            {
                Console.WriteLine($"key:{item.Key},value:{item.Value}");
            }
            Console.WriteLine();




            // Remove all Elements from Dictionary Using Clear method
            x.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {x.Count}");
            Console.ReadKey();



        }
    }
}


       