using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            string imput = Console.ReadLine();
            string name = string.Empty;
            double allProdu = 0;
            int br = 0;
            int br2 = 0;

            while (imput != "Stop")
            {
                name = imput;
                double price = double.Parse(Console.ReadLine());
                br2++;

                if (br2%3==0)
                {
                    price = price / 2;
                }


                if (budjet >= price)
                {
                    budjet -= price;
                    allProdu += price;
                    br++;

                    
                }
                else
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {(price - budjet):f2} leva!");
                    break;
                }

                imput = Console.ReadLine();

            }
            if (imput == "Stop")
            {
                Console.WriteLine($"You bought {br} products for {allProdu:f2} leva.");
            }


        }
    }
}
