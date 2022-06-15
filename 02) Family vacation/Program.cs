using System;

namespace _02__Family_vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percantage = int.Parse(Console.ReadLine());

            double money;
            money = pricePerNight * nights;

            if (nights > 7)
            {
                money -= money * 5 / 100;
            }
            money += budget * percantage / 100;


            if (money <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-money:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{money-budget:f2} leva needed.");
            }
                
                




        }
    }
}
