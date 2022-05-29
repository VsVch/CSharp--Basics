using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {

            double min = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double ulei = double.Parse(Console.ReadLine());
            double secFor = double.Parse(Console.ReadLine());



            double fullTime = ulei / 100;
            fullTime = fullTime * secFor;
            double zabavqne = ulei / 120.000;
            fullTime = fullTime - zabavqne*2.5;

            

            double sum = min * 60.000 + sec;
            

            if (fullTime<= sum)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {fullTime:f3}.");
            }

            else
            {
                Console.WriteLine($"No, Marin failed! He was {(fullTime-sum):f3} second slower.");
            }




            
        }
    }
}
