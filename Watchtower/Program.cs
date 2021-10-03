using System;

namespace Watchtower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for X: ");
            int xValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for y: ");
            int yValue = Convert.ToInt32(Console.ReadLine());

            bool xOver = xValue > 0;
            bool xEqual = xValue == 0;
            bool xBelow = xValue < 0;

            bool yOver = yValue > 0;
            bool yEqual = yValue == 0;
            bool yBelow = yValue < 0;

            if (xOver)
            {
                if (yOver)
                {
                    Console.WriteLine("NE");
                }
                if (yEqual)
                {
                    Console.WriteLine("E");
                }
                if (yBelow)
                {
                    Console.WriteLine("SE");
                }
            }

            if (xEqual)
            {
                if (yOver)
                {
                    Console.WriteLine("N");
                }
                if (yEqual)
                {
                    Console.WriteLine("!");
                }
                if (yBelow)
                {
                    Console.WriteLine("S");
                }
            }

            if (xBelow)
            {
                if (yOver)
                {
                    Console.WriteLine("NW");
                }
                if (yEqual)
                {
                    Console.WriteLine("W");
                }
                if (yBelow)
                {
                    Console.WriteLine("S");
                }
            }
        }
    }
}
