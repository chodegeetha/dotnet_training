using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concurrentqueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            concurrentQueue.Enqueue(10);
            concurrentQueue.Enqueue(20);
            concurrentQueue.Enqueue(30);
            concurrentQueue.Enqueue(40);

            Console.WriteLine($"All Concurrent Queue Elements");
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
            bool IsRemoved = concurrentQueue.TryDequeue(out int x);
            Console.WriteLine($"\nTryDequeue Return : {IsRemoved}");
            Console.WriteLine($"TryDequeue Result Value : {x}");
            bool Ispeeked = concurrentQueue.TryPeek(out int y);
            Console.WriteLine($"\nTrypeek Return : {Ispeeked}");
            Console.WriteLine($"Trypeek Result Value : {y}");
            Console.WriteLine($"All Concurrent Queue Elements");
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }

            int[] arr = new int[5];
            concurrentQueue.CopyTo(arr, 0);
            Console.WriteLine("\nConcurrent Queue Copy Array Elements:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


    }
}
    

