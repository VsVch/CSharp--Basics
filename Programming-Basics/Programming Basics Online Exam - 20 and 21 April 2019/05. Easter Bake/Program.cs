using System;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sumSugar = 0;
            int sumBret = 0;
            int maxSugar = 0;
            int maxBret = 0;
            double pakBret = 0;
            double pakSugar = 0;

            for (int i = 1; i <= n; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int breat = int.Parse(Console.ReadLine());

                sumBret += breat;
                sumSugar += sugar;
                pakBret = Math.Ceiling(1.0*sumBret /750);
                pakSugar = Math.Ceiling(1.0*sumSugar/950);


                if (breat>maxBret)
                {
                    maxBret = breat;
                    
                }

                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }


            }

            Console.WriteLine($"Sugar: {pakSugar}");
            Console.WriteLine($"Flour: {pakBret}");
            Console.WriteLine($"Max used flour is {maxBret} grams, max used sugar is {maxSugar} grams.");


        }
    }
}
