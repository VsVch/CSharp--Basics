using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {

            int numMovie = int.Parse(Console.ReadLine());

            string movieName = string.Empty;
            double rate = 0;
            double minRate = double.MaxValue;
            double maxRate = double.MinValue;
            string minMovie = string.Empty;
            string maxMovie = string.Empty;
            double sum = 0;

            for (int i = 0; i < numMovie; i++)
            {
                movieName = Console.ReadLine();
                rate = double.Parse(Console.ReadLine());
                sum = sum + rate;

                if (rate>maxRate)
                {
                    maxRate = rate;
                    maxMovie = movieName;
                }
                if (rate < minRate)
                {
                    minRate = rate;
                    minMovie = movieName;
                }
            }


            Console.WriteLine($"{maxMovie} is with highest rating: {maxRate:f1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {minRate:f1}");
            Console.WriteLine($"Average rating: {sum/numMovie:f1}");


        }
    }
}
