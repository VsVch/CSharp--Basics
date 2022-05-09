using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine();
            double continueMovie = double.Parse(Console.ReadLine());
            double continueRest = double.Parse(Console.ReadLine());

            double timeLunch = continueRest / 8;
            double otdih = continueRest / 4;

            double sum = continueMovie + timeLunch + otdih;
            
            if (sum <= continueRest)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(continueRest-sum)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(sum-continueRest)} more minutes.");
            }





        }
    }
}
