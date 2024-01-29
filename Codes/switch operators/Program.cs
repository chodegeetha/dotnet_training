using System;

class SwitchExample
{
    static void Main()
    {
        Console.WriteLine("Enter a number (1-3):");
        string input = Console.ReadLine();

        int number;
        if (int.TryParse(input, out number))
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered One.");
                    break;
                case 2:
                    Console.WriteLine("You entered Two.");
                    break;
                case 3:
                    Console.WriteLine("You entered Three.");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
