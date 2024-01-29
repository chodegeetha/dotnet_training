/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arthimeticcalci.Class1 cl = new arthimeticcalci.Class1();
            Console.WriteLine(cl.mod(10, 5));
            Console.ReadLine();
        }
    }
}
*/

using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");
        await MyAsyncMethod();
        Console.WriteLine("End");
        Console.ReadLine();
    }
    static async Task MyAsyncMethod()
    {
        Console.WriteLine("Async Method Start");
        await Task.Delay(2000); // Simulate an asynchronous operation
        Console.WriteLine("Async Method End");
    }
}













