using System;
using System.IO;
using System.Text;
using System.Text.Json;

class Program
{
    static void Main()
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("  World Regions  ");
            Console.WriteLine("=================");
            Console.WriteLine("1. Africa ");
            Console.WriteLine("2. Americas ");
            Console.WriteLine("3. Antarctic ");
            Console.WriteLine("4. Asia ");
            Console.WriteLine("5. Europe ");
            Console.WriteLine("6. Oceania ");
            Console.WriteLine("0. Exit Program ");

            Console.Write("Select your region: ");
            string userChoice = Console.ReadLine() ?? "0";

            if (!int.TryParse(userChoice, out int regionNumber) || regionNumber < 0 || regionNumber > 6)

            {
                Console.WriteLine($"{userChoice} is an invalid choice, try again.");
            }
            else if (regionNumber == 0)
            {
                keepGoing = false;
            }
            else
            {
                string regionName = regionNumber switch
                {
                    1 => "africa",
                    2 => "americas",
                    3 => "antarctic",
                    4 => "asia",
                    5 => "europe",
                    6 => "oceania",
                    _ => ""
                };
                Console.WriteLine(regionName);
            }

        }


        Console.WriteLine("\n\n Have a great day!\n");
    }
}
