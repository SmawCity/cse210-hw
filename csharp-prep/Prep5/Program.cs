using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magic_number)
        {
            Console.Write("Guess the magic number:");

            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magic_number)
            {
                Console.WriteLine("Correct");
            }
        }
    }
}