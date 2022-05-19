using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneyForTrip = double.Parse(Console.ReadLine());
            double realMoneyInPocket = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendingCounter = 0;

            while (realMoneyInPocket < moneyForTrip && spendingCounter < 5)
            {
                string comand = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                dayCounter++;

               

                if (comand == "spend")
                {
                    realMoneyInPocket -= money;
                    spendingCounter++;
                }

                if (comand == "save")
                {
                    realMoneyInPocket += money;

                }

                if (moneyForTrip < 0)
                {

                    
                    break;

                }

                if (spendingCounter == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{ dayCounter} ");

                }

                if (realMoneyInPocket >= moneyForTrip)
                {
                    Console.WriteLine($"You saved the money for {dayCounter} days.");
                }

            }
            




            
        }
    }
}
