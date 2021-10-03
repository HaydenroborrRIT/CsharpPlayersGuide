using System;

namespace MagicCanoon
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index < 101; index++)
            {
                Console.ResetColor();
                if (index % 3 == 0 && index % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{index}: Fire and Electric");
                }
                else if (index % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{index}: Fire");
                }
                else if (index % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{index}: Electric");
                }
                else
                {
                    Console.WriteLine($"{index}: Normal");
                }
            }
        }
    }
}
