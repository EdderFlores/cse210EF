using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;  // Skip further processing and restart the loop
            }

            if (number == 0)
            {
                break;  // Exit the loop if the user enters 0
            }
            numbers.Add(number);
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int? smallestPositive = numbers.Where(n => n > 0).Min();

            numbers.Sort();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive ?? 0}"); // Safe access with null-coalescing operator

            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
