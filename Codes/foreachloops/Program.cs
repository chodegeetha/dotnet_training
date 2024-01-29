using System;

class LoopExamples
{
    static void Main()
    {
        // For Loop
        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // ForEach Loop with an array
        Console.WriteLine("\nForEach Loop:");
        int[] numbers = { 10, 20, 30, 40, 50 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // While Loop
        Console.WriteLine("\nWhile Loop:");
        int counter = 1;
        while (counter <= 5)
        {
            Console.WriteLine(counter);
            counter++;
        }

        // Do-While Loop
        Console.WriteLine("\nDo-While Loop:");
        int doWhileCounter = 1;
        do
        {
            Console.WriteLine(doWhileCounter);
            doWhileCounter++;
        } while (doWhileCounter <= 5);
    }
}
