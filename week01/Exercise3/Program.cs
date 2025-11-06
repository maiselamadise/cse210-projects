using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);

        Console.Write("What is you guess? ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);

        if (guess < magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}