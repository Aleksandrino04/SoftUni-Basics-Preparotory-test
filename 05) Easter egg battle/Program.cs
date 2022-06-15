using System;

namespace _05__Easter_egg_battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsPlayer1 = int.Parse(Console.ReadLine());
            int eggsPlayer2 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            while (input != "End of battle")
            {
                if (input == "one")
                {
                    eggsPlayer2--;
                    if (eggsPlayer2 == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayer1} eggs left. ");
                        break;
                    }
                }
                
                else
                {
                    eggsPlayer1--;
                    if (eggsPlayer1 == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has{eggsPlayer2} eggs left. ");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (eggsPlayer1 > 0 && eggsPlayer2 > 0)
            {
                Console.WriteLine($"Player one has {eggsPlayer1} eggs left.");
                Console.WriteLine($"Player two has {eggsPlayer2} eggs left.");
            }



        }
    }
}
