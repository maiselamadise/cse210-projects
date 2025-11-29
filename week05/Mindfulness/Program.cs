// -----------------------------------------------
// Mindfulness Program - W05
// By: Maisela Manhla Madise
// -----------------------------------------------

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathe = new BreathingActivity("Breathing Activity",
                        "This activity will help you relax by walking you through slow breathing.");
                    breathe.Run();
                    break;

                case "2":
                    ReflectionActivity reflect = new ReflectionActivity("Reflection Activity",
                        "This activity will help you reflect on moments of strength and personal resilience.");
                    reflect.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity("Listing Activity",
                        "This activity helps you list as many positive things as possible in a given area.");
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }

            Console.WriteLine();
        }
    }
}
