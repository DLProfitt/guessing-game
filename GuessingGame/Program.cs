using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random num = new Random();
        int secret = num.Next(1, 100);
        int guessMax = 8;
        int iterator = 8;
        Console.WriteLine("Let's play a guessing game.");
        Console.WriteLine("Pick a difficulty level to get started:");
        Console.WriteLine("1) Easy");
        Console.WriteLine("2) Medium");
        Console.WriteLine("3) Hard");
        string levelSelection = Console.ReadLine();
        int difficultyLevel = int.Parse(levelSelection);

        if (difficultyLevel >= 1 && difficultyLevel <= 4) 
        {
            if (difficultyLevel != 1)
            {
                if (difficultyLevel == 2)
                {
                    guessMax = 6;
                    iterator = 6;
                }
                else
                {
                    guessMax = 4;
                    iterator = 4;
                }
            }

            for (int i = 0; i < iterator; i++)
            {
                int guessesRemaining = guessMax--;

                Console.WriteLine();
                Console.WriteLine($"You have {guessesRemaining} guess(es).");
                Console.WriteLine("What number am I thinking of?");
                string guessString = Console.ReadLine();

                bool parseSuccess = Int32.TryParse(guessString, out int guess);
                if (parseSuccess)
                {
                    if (guess == secret)
                    {
                        Console.WriteLine("Whoa, are you psychic?!");
                        Console.WriteLine("I'm impressed. Let's play again soon.");
                        return;
                    }
                    else
                    {
                        if (i < guessMax)
                        {
                            Console.WriteLine(guess < secret ? "Uh... too low." : "Nope... too high");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    i--;
                }
            }
        } 

        Console.WriteLine("You lose! Better luck next time! Buh-bye");
    }
}
