using System;

namespace _02._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {

            int timeForPhotos = int.Parse(Console.ReadLine());
            int numPhotos = int.Parse(Console.ReadLine());
            int timeForOnePhoto = int.Parse(Console.ReadLine());

            double timePrepare = timeForPhotos * 0.15;
            double timeAllPhotos = numPhotos * timeForOnePhoto;
            double all = timePrepare + timeAllPhotos;
            if (timeForPhotos>=all)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForPhotos-all)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(all-timeForPhotos)} minutes."); 
            }

            


        }
    }
}
