using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberSeries = new List<int>();
        int number = -1;
        do
        {
            Console.Write("Enter a number (0 to Exit): ");
            string response = Console.ReadLine();
            number = int.Parse(response);
            numberSeries.Add(number);
        } while (number != 0);
        int sum = 0;
        foreach (int i in numberSeries)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numberSeries.Count;
        Console.WriteLine($"The average is: {avg}");

        int max = numberSeries.Max();
        Console.WriteLine($"The largest number is: {max}");

        numberSeries.Sort();
        numberSeries.Reverse();
        Console.WriteLine($"Series of numbers: {string.Join(",",numberSeries)}.");
     
    }
}