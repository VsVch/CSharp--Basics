using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                if (num >= 200 && num < 400)
                {
                    p2++;
                }
                if (num >= 400 && num < 600)
                {
                    p3++;
                }
                if (num >= 600 && num < 800)
                {
                    p4++;
                }
                if (num >= 800)
                {
                    p5++;
                }

            }


            Console.WriteLine($"{p1 / n * 100:f2}%");
            Console.WriteLine($"{p2 / n * 100:f2}%");
            Console.WriteLine($"{p3 / n * 100:f2}%");
            Console.WriteLine($"{p4 / n * 100:f2}%");
            Console.WriteLine($"{p5 / n * 100:f2}%");




        }
    }
}
