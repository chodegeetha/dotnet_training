using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start of the program");

        await PerformAsyncTask();

        Console.WriteLine("End of the program");
        Console.ReadLine();
    }

    static async Task PerformAsyncTask()
    {
        Console.WriteLine("Start of the asynchronous task");

       
        await Task.Delay(2000);

        Console.WriteLine("End of the asynchronous task");
        
    }
}

