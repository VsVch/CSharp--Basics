using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            string pole = Console.ReadLine();
            int poimts = 0;
            int numStrack = 0;
            int numStrackWith = 0;
            int restPoints = 301;

            while (pole != "Retire")
            {
                int curentPoints = int.Parse(Console.ReadLine());
                switch (pole)
                {
                    case "Single":
                        poimts = curentPoints;
                        break;
                    case "Double":
                        poimts = 2 * curentPoints;
                        break;
                    case "Triple":
                        poimts =  3 * curentPoints;
                        break;

                    default:
                        break;
                }

                restPoints -= poimts;
                if (restPoints>0)
                {
                    numStrack++;
                }
                else if (restPoints<0)
                {
                    restPoints = restPoints + poimts;
                    numStrackWith++;
                }
                else
                {
                    numStrack++;
                    Console.WriteLine($"{name} won the leg with {numStrack} shots.");
                    break;
                }

                pole = Console.ReadLine();

            }

            if (pole == "Retire")
            {
                Console.WriteLine($"{name} retired after {numStrackWith} unsuccessful shots.");
            }

        }
    }
}
