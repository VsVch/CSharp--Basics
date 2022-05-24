using System;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine();

            int sum = 0;
            string bestMovie = "";
            int bestSum = 0;
            

            while (movieName != "STOP")
            {

                int curentSum = 0;
                sum++;
                if (sum>7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }


                for (int i = 0; i < movieName.Length; i++)
                {

                    if (char.IsUpper(movieName[i]))
                    {
                        curentSum += movieName[i] - movieName.Length;
                    }
                    else if (char.IsLower(movieName[i]))
                    {
                        curentSum += movieName[i] - 2 * movieName.Length;
                    }
                    else
                    {
                        curentSum += movieName[i];
                    }

                }


                if (curentSum > bestSum )
                {
                    bestSum = curentSum;
                    bestMovie = movieName;
                }

                movieName = Console.ReadLine();

            }


            Console.WriteLine($"The best movie for you is {bestMovie} with {bestSum} ASCII sum.");



        }
    }
}
