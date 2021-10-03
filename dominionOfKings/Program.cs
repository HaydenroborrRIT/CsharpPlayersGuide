using System;

namespace dominionOfKings
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PROVINCES_SCORE = 6;
            double provinces = 0;
            const double DUCHIES_SCORE = 3;
            double duchies = 0;
            const double ESTATES_SCORE = 1;
            double estates = 0;
            double totalPoints = 0;
            
            Console.Write("Enter the number of Provinces you have: ");
            if (!double.TryParse(Console.ReadLine(), out provinces))
            {
                Console.WriteLine("Fuck");
            }
            Console.Write("Enter the number of duchies you have: ");
            if (!double.TryParse(Console.ReadLine(), out duchies))
            {
                Console.WriteLine("Fuck");
            }
            Console.Write("Enter the number of estates you have: ");
            if (!double.TryParse(Console.ReadLine(), out estates))
            {
                Console.WriteLine("Fuck");
            }

            totalPoints = (provinces * PROVINCES_SCORE) + (duchies * DUCHIES_SCORE) + (estates * ESTATES_SCORE);
            Console.Write($"\nYou have {totalPoints} points.\n");
        }
    }
}
