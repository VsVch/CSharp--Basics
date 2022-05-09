using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {

            double records = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeOneMetre = double.Parse(Console.ReadLine());

            double syprotiva = Math.Floor(distance/15);

            double sum = syprotiva * 12.5 + distance * timeOneMetre;
            if (sum<records)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sum:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(sum-records):f2} seconds slower.");
            }





        }
    }
}
