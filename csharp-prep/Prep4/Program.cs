using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        while ((number = int.Parse(Console.ReadLine()))!=0)
        {
            numbers.Add(number);
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += number;
        }

        double average = sum / (double)numbers.Count;

        int largestNumber = numbers.Max();

        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The average is: {0}", average);
        Console.WriteLine("The largest number is: {0}", largestNumber);
    }
}