using System;

namespace repairingTheClocktower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
