using System;

class Program
{
    static void Main()
    {
        Random num = new Random();
        int secret = num.Next(1, 100);
        int guessMax;
        int level;

        Console.WriteLine("Let's play a guessing game.");
        Console.WriteLine("Pick a difficulty level to get started:");
        Console.WriteLine("1) Cheater");
        Console.WriteLine("2) Easy");
        Console.WriteLine("3) Medium");
        Console.WriteLine("4) Hard");
        string levelSelection = Console.ReadLine();

        int difficultyLevel = int.Parse(levelSelection);
        switch (difficultyLevel)
        {
            case 1: // Cheater
                guessMax = -1; // Infinite guesses
                break;
            case 2: // Easy
                guessMax = 8;
                break;
            case 3: // Medium
                guessMax = 6;
                break;
            case 4: // Hard
                guessMax = 4;
                break;
            default: // Invalid input
                Console.WriteLine("Not an option! Guess I'll pick for you.");
                Console.WriteLine("Eeny, meeny, miny... Hard! Good luck.");
                guessMax = 4;
                break;
        }

        level = guessMax;
        GuessingGame(secret, ref guessMax, level);

        Console.WriteLine("You lose! Better luck next time! Buh-bye");
    }

    static void GuessingGame(int secret, ref int guessMax, int level)
    {
        for (int i = 0; guessMax < 0 || i < level; i++)
        {
            int guessesRemaining = guessMax--;

            Console.WriteLine();

            if (guessMax >= 0)
            {
                Console.WriteLine($"You have {guessesRemaining} guess(es).");
            }

            Console.WriteLine("What number am I thinking of?");
            string guessString = Console.ReadLine();

            bool guessIsInt = Int32.TryParse(guessString, out int guess);
            if (guessIsInt)
            {
                if (guess == secret)
                {
                    Console.WriteLine("Whoa, are you psychic?!");
                    Console.WriteLine("I'm impressed. Let's play again soon.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine(guess < secret ? "Uh... too low." : "Nope... too high");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 1-100.");
                guessMax++;
                i--;
            }
        }
    }
}
