using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int r = 0;
            int o = 0;
            int y = 0;
            int w = 0;
            int b = 0;
            int a = 0;
            int points2 = 0;
            


            for (int i = 1; i <= n; i++)
            {
                string points = Console.ReadLine();
                switch (points)
                {

                    case "red":
                        points2 += 5;
                        
                        r++;
                        break;
                    case "orange":
                        points2 += 10;
                        o++;
                        break;
                    case "yellow":
                        points2 += 15;
                        y++;
                        break;
                    case "white":
                        points2 += 20;
                        w++;
                        break;
                    case "black":
                        points2 = points2 / 2;
                        b++;
                        break;
                    default:
                        a++;
                        break;
                }
            }
            double sum = r + o + y + w + b;

            Console.WriteLine($"Total points: {points2}");
            Console.WriteLine($"Points from red balls: {r}");
            Console.WriteLine($"Points from orange balls: {o}");
            Console.WriteLine($"Points from yellow balls: {y}");
            Console.WriteLine($"Points from white balls: {w}");
            Console.WriteLine($"Other colors picked: {a}");
            Console.WriteLine($"Divides from black balls: {b}");


        }
    }
}
