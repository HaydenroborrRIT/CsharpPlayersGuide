using System;

namespace thePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int theNumber = Convert.ToInt32(Console.ReadLine());
            while (theNumber >= 100 || theNumber <= 0)
            {
                Console.Write("Please enter a number between 1-100: ");
                theNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            const string guessing = "What is your next guess? ";

            Console.WriteLine("User 2, guess a number.");
            int guess = 0;
            while (guess != theNumber)
            {
                if (guess == 0)
                {
                    Console.Write(guessing);
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                if (guess > theNumber)
                {
                    Console.WriteLine($"{guess} is too high.");
                    Console.Write(guessing);
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                if (guess < theNumber)
                {
                    Console.WriteLine($"{guess} is too low.");
                    Console.Write(guessing);
                    guess = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("You guessed the number!");
        }
    }
}
