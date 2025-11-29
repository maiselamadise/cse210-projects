using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn from this experience?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel afterwards?",
        "What made this different from other times?"
    };

    public ReflectionActivity(string name, string description)
        : base(name, description) { }

    public void Run()
    {
        DisplayStart();
        Random rnd = new Random();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---\n");

        int duration = GetDuration();
        int elapsed = 0;

        List<string> usedQuestions = new List<string>();

        while (elapsed < duration)
        {
            string q = _questions[rnd.Next(_questions.Count)];

            // Avoid repeating questions
            while (usedQuestions.Contains(q))
                q = _questions[rnd.Next(_questions.Count)];

            usedQuestions.Add(q);

            Console.WriteLine(q);
            ShowSpinner(4);
            elapsed += 4;

            if (usedQuestions.Count == _questions.Count)
                usedQuestions.Clear();
        }

        LogActivity();
        DisplayEnd();
    }
}
