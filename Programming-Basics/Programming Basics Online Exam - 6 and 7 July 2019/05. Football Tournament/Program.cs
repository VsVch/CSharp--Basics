using System;

namespace _05._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameTeam = Console.ReadLine();
            double numGames = double.Parse(Console.ReadLine());
            int point = 0;
            double numberGamesW = 0;
            double numberGamesD = 0;
            double numberGamesL = 0;
            double sum = 0;


            if (numGames < 1)
            {
                Console.WriteLine($"{nameTeam} hasn't played any games during this season.");
            }
            else
            {
                for (int i = 0; i < numGames; i++)
                {
                    string result = Console.ReadLine();
                    if (result == "W")
                    {
                        point += 3;
                        numberGamesW++;
                    }
                    else if (result == "D")
                    {
                        point += 1;
                        numberGamesD++;
                    }
                    else if (result == "L")
                    {
                        point += 0;
                        numberGamesL++;
                    }

                }
                sum = 1 * numberGamesW / numGames * 100;

                //Console.WriteLine($"{nameTeam} hasn't played any games during this season.");


                {
                    Console.WriteLine($"{nameTeam} has won {point} points during this season.");
                    Console.WriteLine($"Total stats:");
                    Console.WriteLine($"## W: {numberGamesW}");
                    Console.WriteLine($"## D: {numberGamesD}");
                    Console.WriteLine($"## L: {numberGamesL}");
                    Console.WriteLine($"Win rate: {sum:f2}%");
                }




            }







        }
    }
}
