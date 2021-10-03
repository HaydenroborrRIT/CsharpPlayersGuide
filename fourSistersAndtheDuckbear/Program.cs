using System;

namespace fourSistersAndtheDuckbear
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            
            Console.Write("Enter a number of chocolate eggs: ");
            if(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Fuck");
            }

            int eggsForSisters = input / 3;
            int eggsForDuckbear = input % 3;

            Console.WriteLine($"Each sisters get {eggsForSisters} chocolate eggs.");
            Console.WriteLine($"Duckbear get {eggsForDuckbear} chocolate eggs.");
        }
    }
}
