using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public int Mood { get; set; }  // Mood rating from 1–5

    public Entry(string date, string prompt, string response, int mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public string FormatForDisplay()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nMood: {Mood}/5\n";
    }

    public string FormatForFile()
    {
        return $"{Date}|{Prompt}|{Response}|{Mood}";
    }

    public static Entry ParseFromFile(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2], int.Parse(parts[3]));
    }
}
