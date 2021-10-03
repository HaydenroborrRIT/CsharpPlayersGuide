using System;

namespace BuyingInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            double ropePrice = 10;
            string option1 = "Rope";
            double torchesPrice = 15;
            string option2 = "Torches";
            double climbingEquimentsPrice = 25;
            string option3 = "Climbing Equiments";
            double cleanWaterPrice = 1;
            string option4 = "Clean Water";
            double machetePrice = 20;
            string option5 = "Machete";
            double canoePrice = 200;
            string option6 = "Canoe";
            double foodSuppliesPrice = 1;
            string option7 = "Food Supplies";
            const double discount = 0.5;
            bool getDiscount = false;

            Console.Write("Hello, what's your name? ");
            string name = Console.ReadLine();
            if (name == "Hayden")
            {
                getDiscount = true;
            }

            if (getDiscount)
            {
                ropePrice *= discount;
                torchesPrice *= discount;
                climbingEquimentsPrice *= discount;
                cleanWaterPrice *= discount;
                machetePrice *= discount;
                canoePrice *= discount;
                foodSuppliesPrice *= discount;


            }

            Console.WriteLine("The following items are availble: ");
            Console.WriteLine($"1 - {option1}\n2 - {option2}\n3 - {option3}\n4 - {option4}\n5 - {option5}\n6 - {option6}\n7 - {option7}");
            Console.Write("What number do you want to see the price of? ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine($"{option1} cost {ropePrice} gold.");
                    break;
                case "2":
                    Console.WriteLine($"{option2} cost {torchesPrice} gold.");
                    break;
                case "3":
                    Console.WriteLine($"{option3} cost {climbingEquimentsPrice} gold.");
                    break;
                case "4":
                    Console.WriteLine($"{option4} cost {cleanWaterPrice} gold.");
                    break;
                case "5":
                    Console.WriteLine($"{option5} cost {machetePrice} gold.");
                    break;
                case "6":
                    Console.WriteLine($"{option6} cost {canoePrice} gold.");
                    break;
                case "7":
                    Console.WriteLine($"{option7} cost {foodSuppliesPrice} gold.");
                    break;
                default:
                    Console.WriteLine("Sorry we don't have that here");
                    break;
            }
        }
    }
}
