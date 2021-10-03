using System;

namespace ReplicatorOfD_to
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[5];
            for (int index = 0; index < 5; index++)
            {
                Console.Write($"Please enter a number for index {index}: ");
                array[index] = Console.ReadLine();
            }
            int[] arrayNum = new int[5];
            for (int index = 0; index < 5; index++)
            {
                arrayNum[index] = Convert.ToInt32(array[index]);
                Console.WriteLine($"Second array {index}: {arrayNum[index]}");
            }

        }
    }
}
