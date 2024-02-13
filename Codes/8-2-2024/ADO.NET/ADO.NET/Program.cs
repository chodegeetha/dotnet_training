using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;



namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user input");
            String n = Console.ReadLine();
            switch (n)
            {

                case "1":
                    Insertion();
                    break;
                case "2":
                    Updation();
                    break;
                case "3":
                    Deletion();
                    break;
                case "4":
                    Selection();
                    break;
                default:
                    Console.WriteLine("Invalid user input");
                    break;
            }
        }

        static void Insertion()
        {
            Insert.Insertsp(244, "Tips for Effective Time Management", "Managing time effectively is essential for productivity and success in both personal and professional life", new DateTime(2024, 02, 19, 09, 15, 30),
               new DateTime(2024, 02, 18, 09, 20, 30), 11, 71);
            Insert.InsertUser();
            Console.ReadLine();

        }

        static void Updation()
        {
            update.UpdateUserDetails(14, "ajji", "ajji23@gmail.com");
            Console.ReadLine();
        }

        static void Deletion()
        {
            Delete.DeleteUser(28);
            Console.ReadLine();
        }

        static void Selection()
        {
            Select.Selectuser();
            Console.ReadLine();
        }
    }
}










        /* Insert.Insertsp(244, "Tips for Effective Time Management", "Managing time effectively is essential for productivity and success in both personal and professional life", new DateTime(2024, 02, 19, 09, 15, 30),
             new DateTime(2024, 02, 18, 09, 20, 30), 11, 71);*/

        /*update.UpdateCategory(71, "New Technology", "Latest technology trends and innovations");*/
        /* Insert.Insertsp(259, "The Power of Positive Thinking", "Positive thinking can transform your life by improving your mental and physical well-being.", new DateTime(2024, 03, 10, 08, 30, 00),
           new DateTime(2024, 03, 10, 08, 35, 00), 14, 41);*/

        /*update.UpdateUserDetails(13, "akki", "akki23@gmail.com");*/
        /*Delete.DeleteCategory(85);*/
        /*Insert.InsertUser();*/
        /*Delete.DeleteUser(18);*/
       /* Select.Selectuser();
            *//*Select.SelectCategories();*//*

        }
    }
}
     */