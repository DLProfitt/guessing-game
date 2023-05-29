using System;

class Program
{
    static void Main()
    {
        int secret = 42;
        Console.WriteLine("You will have 4 attempts to guess my secret number.");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("What number am I thinking of? ");
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
