using System;

namespace triangleFarmer
//here?
{
    //or here?
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base of triangle : ");
            double triangleBase = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of triangle: ");
            double triangleHeight = double.Parse(Console.ReadLine());

            double triangleArea = (triangleBase * triangleHeight) / 2;
            Console.WriteLine("Your trianlge area is " + triangleArea);
        }
    }
}