using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();


            int firstScore = 0;
            int secondScore = 0;
            int finalFirstScore = 0;
            int finalSecondScore = 0;
            int s1 = 0;
            int s2 = 0;
            string theWinnner = string.Empty;
            int score = 0;


            string isEnd = Console.ReadLine();

            while (isEnd != "End of game")
            {

                firstScore = int.Parse(isEnd);
                secondScore = int.Parse(Console.ReadLine());

                if (firstScore > secondScore)
                {
                    finalFirstScore = firstScore - secondScore;
                    s1 += finalFirstScore;
                }
                else if (secondScore > firstScore)
                {
                    finalSecondScore = secondScore - firstScore;
                    s2 += finalSecondScore;
                }
                else if (firstScore == secondScore)
                {
                    firstScore = int.Parse(Console.ReadLine());
                    secondScore = int.Parse(Console.ReadLine());

                    if (firstScore > secondScore)
                    {
                        theWinnner = firstPlayer;
                        score = s1;
                        Console.WriteLine($"Number wars!");

                        Console.WriteLine($"{theWinnner} is winner with {score} points");
                        break;



                    }
                    else
                    {
                        theWinnner = secondPlayer;
                        score = s2;
                        Console.WriteLine($"Number wars!");

                        Console.WriteLine($"{theWinnner} is winner with {score} points");
                        break;
                    }
                }






                isEnd = Console.ReadLine();
            }




            if (isEnd == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {s1} points");
                Console.WriteLine($"{secondPlayer} has {s2} points");
                
            }






        }
    }
}
