using System;

namespace _06._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameTurnir = Console.ReadLine();
            double win = 0;
            double lose = 0;

            while (nameTurnir != "End of tournaments")
            {

                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    int goalDesi = int.Parse(Console.ReadLine());
                    int antiDesi = int.Parse(Console.ReadLine());

                    if (goalDesi>antiDesi)
                    {
                        Console.WriteLine($"Game {i} of tournament {nameTurnir}: win with {goalDesi-antiDesi} points.");
                        win++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {nameTurnir}: lost with {antiDesi-goalDesi} points.");
                        lose++;
                    }

                }



                nameTurnir = Console.ReadLine();
            }

            double sum = win + lose;

            if (nameTurnir == "End of tournaments")
            {
                Console.WriteLine($"{win/sum*100:f2}% matches win");
                Console.WriteLine($"{lose / sum*100:f2}% matches lost");
            }




        }
    }
}
