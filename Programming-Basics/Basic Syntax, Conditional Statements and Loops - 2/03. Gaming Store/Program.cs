using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double money = currentBalance;
            string newGame = Console.ReadLine();
            double priceGame = 0;
            while (newGame != "Game Time")
            {
                switch (newGame)
                {

                    case "OutFall 4":
                        priceGame = 39.99;
                        currentBalance -= priceGame;
                        if (currentBalance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            currentBalance += priceGame;
                        }
                        else
                        {
                            Console.WriteLine($"Bought OutFall 4");
                        }
                        break;
                    case "CS: OG":
                        priceGame = 15.99;
                        currentBalance -= priceGame;
                        if (currentBalance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            currentBalance += priceGame;
                        }
                        else
                        {
                            Console.WriteLine($"Bought CS: OG");
                        }
                        break;
                    case "Zplinter Zell":
                        priceGame = 19.99;
                        currentBalance -= priceGame;
                        if (currentBalance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            currentBalance += priceGame;
                        }
                        else
                        {
                            Console.WriteLine($"Bought Zplinter Zell");
                        }
                        break;
                    case "Honored 2":
                        priceGame = 59.99;
                        currentBalance -= priceGame;
                        if (currentBalance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            currentBalance += priceGame;
                        }
                        else
                        {
                            Console.WriteLine($"Bought Honored 2");
                        }
                        break;
                    case "RoverWatch":
                        priceGame = 29.99;
                        currentBalance -= priceGame;
                        if (currentBalance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            currentBalance += priceGame;
                        }
                        else
                        {
                            Console.WriteLine($"Bought RoverWatch");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        priceGame = 39.99;
                        currentBalance -= priceGame;
                        if (currentBalance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            currentBalance += priceGame;
                        }
                        else
                        {
                            Console.WriteLine($"Bought RoverWatch Origins Edition");
                        }
                        break;

                    default:
                        Console.WriteLine($"Not Found");
                        break;
                }


                if (currentBalance == 0)
                {
                    Console.WriteLine($"Out of money!");
                    break;
                }



                newGame = Console.ReadLine();
            }

            if (newGame == "Game Time")
            {
                Console.WriteLine($"Total spent: ${(money - currentBalance):f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
