using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceBasketEggs = 1.5;
            double priceWreath = 3.8;
            double priceChocolateBunny = 7;
            double localPrice = 0;
            double sumPrice = 0;
            int genNumber = 0;

            int customerNumber = int.Parse(Console.ReadLine());
            int localNumber = 0;

            for (int i = 0; i < customerNumber; i++)
            {
                string bay = Console.ReadLine();
                localNumber = 0;
                localPrice = 0;
                while (bay != "Finish")
                {
                    
                    localNumber++;
                    genNumber++;
                    switch (bay)
                    {
                        case "basket":
                            localPrice += priceBasketEggs;
                            break;
                        case "wreath":
                            localPrice += priceWreath;
                            break;
                        case "chocolate bunny":
                            localPrice += priceChocolateBunny;
                            break;
                        default:
                            break;
                    }






                    bay = Console.ReadLine();

                }

                if (localNumber%2==0)
                {
                    localPrice = localPrice * .8;
                }
                sumPrice += localPrice;


                Console.WriteLine($"You purchased {localNumber} items for {localPrice:f2} leva.");
            }


            Console.WriteLine($"Average bill per client is: {(sumPrice/customerNumber):f2} leva.");


        }
    }
}
