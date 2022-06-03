using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {

            string bestPlayer = Console.ReadLine();
            int bestGoal = 0;
            string newBestPlayer = string.Empty;
            int goals = 0;

            while (bestPlayer != "END")
            {
                
                goals = int.Parse(Console.ReadLine());
                if (goals > bestGoal)
                {
                    bestGoal = goals;
                    newBestPlayer = bestPlayer;
                }

                if (bestGoal >= 10)
                {
                    break;
                }


                bestPlayer = Console.ReadLine();
            }


            


            Console.WriteLine($"{newBestPlayer} is the best player!");


            if (bestGoal >= 3)
            {
                Console.WriteLine($"He has scored {bestGoal} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoal} goals.");
            }


        }
    }
}
