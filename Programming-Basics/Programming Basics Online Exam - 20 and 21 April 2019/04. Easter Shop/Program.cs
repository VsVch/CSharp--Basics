using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstBeginningEggs = int.Parse(Console.ReadLine());
            string imput = string.Empty;
            
            int sumBuyEggs = 0;
            

            while (imput != "Close")
            {

                
                if (imput == "Buy" )
                {
                    int buyEggs = int.Parse(Console.ReadLine());
                    if (buyEggs > firstBeginningEggs)
                    {
                        Console.WriteLine($"Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {firstBeginningEggs}.");
                        break;
                    }
                    else
                    {
                        firstBeginningEggs = firstBeginningEggs - buyEggs;
                        sumBuyEggs += buyEggs;
                    }
                    
                }
                else if (imput == "Fill")
                {
                    int fillEggs = int.Parse(Console.ReadLine());
                    firstBeginningEggs += fillEggs;

                }

                imput = Console.ReadLine();
            }
            if (imput == "Close")
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{sumBuyEggs} eggs sold.");
            }
        }
    }
}
