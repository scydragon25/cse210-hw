using System;

class Program
{
    static void Main(string[] args)
    {
        // 1.   Ask the user for their grade percentage.
        Console.Write("What is the grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        /* 1. Print out the appropriate letter grade.
        if (grade < 60)
        {
            Console.WriteLine("Your grade letter is F.");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Your grade letter is D.");
        }
        else if (grade < 80)
        {
            Console.WriteLine("Your grade letter is C.");
        }
        else if (grade < 90)
        {
            Console.WriteLine("Your grade letter is B.");
        }
        else if (grade < 100)
        {
            Console.WriteLine("Your grade letter is A.");
        }*/

        // 3.   Instead reduce the above code to have one write
        //      statement.
        char letterGrade = 'W';
        if (grade < 60)
        {
            letterGrade = 'F';
        }
        else if (grade < 70)
        {
            letterGrade = 'D';
        }
        else if (grade < 80)
        {
            letterGrade = 'C';
        }
        else if (grade < 90)
        {
            letterGrade = 'B';
        }
        else if (grade >= 90)
        {
            letterGrade = 'A';
        }
        Console.WriteLine($"Your grade letter is {letterGrade}.");
        
        // 2.   Did they pass the class?
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You Passed.");
        }
        else
        {
            Console.WriteLine("You did not pass, but keep " +
                                "moving forwad!");
        }
    }
}