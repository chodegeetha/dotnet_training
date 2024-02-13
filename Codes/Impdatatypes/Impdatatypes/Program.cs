using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impdatatypes
{


    class Program
    {
        static void Main()
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Define a future date
            DateTime futureDate = new DateTime(2023, 12, 31);

            // Calculate the difference between the current date and the future date
            TimeSpan timeDifference = futureDate - currentDate;

            // Display the difference in days, hours, minutes, and seconds
            Console.WriteLine($"Days until {futureDate}: {timeDifference.Days}");
            Console.WriteLine($"Hours until {futureDate}: {timeDifference.Hours}");
            Console.WriteLine($"Minutes until {futureDate}: {timeDifference.Minutes}");
            Console.WriteLine($"Seconds until {futureDate}: {timeDifference.Seconds}");

            // Calculate the age based on the birthdate
            DateTime birthdate = new DateTime(1990, 5, 20);
            TimeSpan ageDifference = currentDate - birthdate;
            int ageInYears = ageDifference.Days / 365;

            // Display the age
            Console.WriteLine($"Age: {ageInYears} years");
            // Performing operations with DateTime
            DateTime futureDateTime = currentDate.AddDays(7);
            Console.WriteLine("Date 7 days from now: " + futureDateTime);

            // Formatting DateTime to a custom string
            string formattedDateTime = currentDate.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Formatted Date and Time: " + formattedDateTime);
            Console.ReadLine();
        }
    }
}
