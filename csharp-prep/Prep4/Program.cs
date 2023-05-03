using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = 0;
        int sum = 0;
        float average = 0;

        Console.WriteLine("Enter a list of number, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        } while (input != 0);
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        float trueCount = numbers.Count -1; // The element 0 should be ignored
        average = sum / trueCount;
        numbers.Sort(); // Put the list in ascending order
        numbers.Reverse();  // Put the list in descending order

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {numbers[0]}");
    }
}