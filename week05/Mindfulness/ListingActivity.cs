using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "What made you smile recently?",
        "Who are some of your heroes?"
    };

    public ListingActivity(string name, string description)
        : base(name, description) {}

    public void Run()
    {
        DisplayStart();
        Random rnd = new Random();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---\n");

        Console.WriteLine("You may begin in:");
        Countdown(5);
        Console.WriteLine();

        List<string> items = new List<string>();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("→ ");
            string entry = Console.ReadLine();
            items.Add(entry);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        LogActivity();
        DisplayEnd();
    }
}
