using System;

class Program
{
    static void Main()
    {
        Random num = new Random();
        int secret = num.Next(1, 100);
        int guessMax = 4;
        Console.WriteLine("Bet you can't guess my secret number!");
        for (int i = 0; i < 4; i++)
        {
            int guessesRemaining = guessMax--;
            Console.WriteLine();
            Console.WriteLine($"You have {guessesRemaining} guesses.");
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
                    if (i < 3)
                    {
                        Console.WriteLine("Uh... No! Try again.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                i--;
            }
        }

        Console.WriteLine("You lose! Better luck next time! Buh-bye");
    }
}
