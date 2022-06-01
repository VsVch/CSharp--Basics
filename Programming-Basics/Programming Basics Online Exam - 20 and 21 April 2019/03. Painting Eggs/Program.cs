using System;

namespace _03._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {

            string sizeEggs = Console.ReadLine();
            string colourEggs = Console.ReadLine();
            int numPartidi = int.Parse(Console.ReadLine());
            double priceOne = 0;

            switch (sizeEggs)
            {

                case "Large":
                    switch (colourEggs)
                    {
                        case "Red":
                            priceOne = 16;
                            break;
                        case "Green":
                            priceOne = 12;
                            break;
                        case "Yellow":
                            priceOne = 9;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Medium":
                    switch (colourEggs)
                    {
                        case "Red":
                            priceOne = 13;
                            break;
                        case "Green":
                            priceOne = 9;
                            break;
                        case "Yellow":
                            priceOne = 7;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Small":
                    switch (colourEggs)
                    {
                        case "Red":
                            priceOne = 9;
                            break;
                        case "Green":
                            priceOne = 8;
                            break;
                        case "Yellow":
                            priceOne = 5;
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            double sum = numPartidi * priceOne;
            sum = sum - sum * 0.35;
            Console.WriteLine($"{sum:f2} leva.");


        }
    }
}
