using System;

namespace DefenseOfConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            int targetRow = 0;
            int targetColumn = 0;
            Console.Write("Target Row? ");
            targetRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            targetColumn = Convert.ToInt32(Console.ReadLine());

            string pointA = $"({targetRow}, {targetColumn -1})";
            string pointB = $"({targetRow -1}, {targetColumn})";
            string pointC = $"({targetRow}, {targetColumn +1})";
            string pointD = $"({targetRow +1}, {targetColumn})";
            Console.WriteLine("Deloy to:");
            Console.WriteLine($"{pointA}\n{pointB}\n{pointC}\n{pointD}\n");
            Console.Beep();
        }
    }
}
