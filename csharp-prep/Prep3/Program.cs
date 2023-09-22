using System.Reflection.PortableExecutable;
using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = new Random().Next(1,101);

        bool guessedCorrectly = false;
        while (!guessedCorrectly)
        {
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                guessedCorrectly = true;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lowe");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}