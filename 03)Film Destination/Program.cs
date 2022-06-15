using System;

namespace _03_Film_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double money = 0;

            if (destination == "Dubai")
            {
                if (season == "Summer")
                {
                    money = days * 40000;
                }
                else
                {
                    money = days * 45000;
                }
                money -= money * 30 / 100;

            }
            else if (destination == "Sofia")
            {
                if (season == "Summer")
                {
                    money = days * 12500;
                }
                else
                {
                    money = days * 17000;
                }
                money += money * 25 / 100;
            }
            else
            {
                if (season == "Summer")
                {
                    money = days * 20250;
                }
                else
                {
                    money = days * 24000;
                }
            }
            if (budget >= money)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - money:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {money-budget:f2} leva more!");
            }
        }
    }
}
               

              





