using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;

        // 3. Random Magic Number
        Random randomGenerator = new Random();
        int ans = randomGenerator.Next(1, 100);
        
        // 1. Ask for the magic number.
        //Console.Write("What is the magic number? ");
        //ans = int.Parse(Console.ReadLine());

        do
        {
            // Ask the user for a guess.
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Higher or Lower?
            if (guess == ans)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < ans)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (guess != ans);
    }
}