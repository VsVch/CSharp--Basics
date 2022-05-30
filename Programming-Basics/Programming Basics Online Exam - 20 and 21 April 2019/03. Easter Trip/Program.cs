using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            string data = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double priceOneNigjt = 0;

            switch (destination)
            {

                case "France":
                    switch (data)
                    {
                        case "21-23":
                            priceOneNigjt = 30;
                            break;
                        case "24-27":
                            priceOneNigjt = 35;
                            break;
                        case "28-31":
                            priceOneNigjt = 40;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Italy":
                    switch (data)
                    {
                        case "21-23":
                            priceOneNigjt = 28;
                            break;
                        case "24-27":
                            priceOneNigjt = 32;
                            break;
                        case "28-31":
                            priceOneNigjt = 39;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Germany":
                    switch (data)
                    {
                        case "21-23":
                            priceOneNigjt = 32;
                            break;
                        case "24-27":
                            priceOneNigjt = 37;
                            break;
                        case "28-31":
                            priceOneNigjt = 43;
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            double sum = priceOneNigjt * numNights;
            Console.WriteLine($"Easter trip to {destination} : {sum:f2} leva.");

        }
    }
}
