using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayStart()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("\nHow long (in seconds) would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(4);
    }

    protected void DisplayEnd()
    {
        Console.WriteLine("\nGreat job!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou completed the {_name} for {_duration} seconds.");
        ShowSpinner(4);
    }

    protected int GetDuration()
    {
        return _duration;
    }

    // Spinner animation
    protected void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(frames[i]);
            Thread.Sleep(150);
            Console.Write("\b");
            i = (i + 1) % frames.Length;
        }
    }

    // Countdown animation
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void LogActivity()
    {
        string entry = $"{DateTime.Now}: Completed {_name} for {GetDuration()} seconds";
        File.AppendAllText("activity_log.txt", entry + Environment.NewLine);
    }
}
