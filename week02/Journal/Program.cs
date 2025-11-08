using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load entries from file");
            Console.WriteLine("4. Save entries to file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Code to write a new entry
                    Console.WriteLine("Writing a new entry...");
                    break;
                case "2":
                    // Code to display all entries
                    Console.WriteLine("Displaying all entries...");
                    break;
                case "3":
                    // Code to load entries from file
                    Console.WriteLine("Loading entries from file...");
                    break;
                case "4":
                    // Code to save entries to file
                    Console.WriteLine("Saving entries to file...");
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

internal class Journal
{
}