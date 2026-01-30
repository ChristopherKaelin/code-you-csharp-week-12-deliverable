using System;
using System.IO;
using System.Text;
using System.Text.Json;

class Program
{
    static void Main()
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

        Console.Write("Select your region: ");
        string userChoice = Console.ReadKey().Key.ToString();


        Console.WriteLine("\n\n Have a great day!\n");
    }
}
