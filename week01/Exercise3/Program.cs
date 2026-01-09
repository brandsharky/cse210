using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        Random random = new Random();

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101);
            int guess = -1; // Initialize to something not equal to magicNumber
            int guesses = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"You guessed it in {guesses} guesses!");
            Console.Write("Do you want to play again? (yes/no) ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playAgain = false;
            }
        }
    }
}