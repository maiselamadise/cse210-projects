using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description) {}

    public void Run()
    {
        DisplayStart();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown(4);
            Console.WriteLine();

            elapsed += 8;
        }

        LogActivity();
        DisplayEnd();
    }
}
