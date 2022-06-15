using System;

namespace _01_Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double raspberriesPrice = strawberriesPrice / 2; 

            double strawberries = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());

            bananas *= raspberriesPrice * 20 / 100;
            oranges *= raspberriesPrice * 60 / 100;
            strawberries *= strawberriesPrice;
            raspberries *= raspberriesPrice;

            Console.WriteLine($"{bananas + oranges + strawberries + raspberries:f2}");


        }
    }
}
