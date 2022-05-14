using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int points1 = int.Parse(Console.ReadLine());
            int points = 0;
            double numW = 0;

            for (int i = 0; i < num; i++)
            {

                string etap = Console.ReadLine();

                if (etap == "W")
                {
                    points += 2000;
                    numW++;
                }
                else if (etap == "F")
                {
                    points += 1200;
                }
                else
                {
                    points += 720;
                }





            }


            Console.WriteLine($"Final points: {points + points1}");
            Console.WriteLine($"Average points: {((points / num)):f0}");
            Console.WriteLine($"{(numW / num * 100):f2}%");




        }
    }
}