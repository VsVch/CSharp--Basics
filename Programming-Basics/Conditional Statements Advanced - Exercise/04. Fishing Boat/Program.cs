using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int parce = 0;

            switch (season)
            {
                case "Spring":
                    parce = 3000;
                    break;
                case "Summer":
                    parce = 4200;
                    break;
                case "Autumn":
                    parce = 4200;
                    break;
                case "Winter":
                    parce = 2600;
                    break;


                default:
                    break;
            }

            Console.WriteLine(parce);

            if (num <= 6)
            {
                parce = parce - parce * 10 / 100;
            }
            else if (num > 7 && num <= 11)
            {
                parce = parce - parce * 15 / 100;
            }
            else 
            {
                parce = parce - parce* 25 / 100;
            }

            Console.WriteLine(parce);

            if (num % 2 == 0 && season != "Autumn")
            {
                parce = parce - parce * 5 / 100;
            }

            Console.WriteLine(parce);

            if (budjet>parce)
            {
                Console.WriteLine($"Yes! You have {(budjet-parce):f2} leva left.");

            }



            else
            {
                Console.WriteLine($"Not enough money! You need {(parce-budjet):f2} leva.");
            }
        }
    }
}
