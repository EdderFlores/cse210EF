using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);  // Random number between 1 and 100
            int guess = 0;
            int numGuesses = 0;

            Console.WriteLine("I have picked a magic number between 1 and 100. Try to guess it!");

            while (true)  // Changed to an infinite loop to better manage flow
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess)) // Safely try to parse user input
                {
                    numGuesses++;
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
                        Console.WriteLine($"You guessed it in {numGuesses} guesses!");
                        break;  // Exit the loop if the correct number is guessed
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer number.");
                }
            }

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }
    }
}