using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {



            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double money = 0;
            int toyCounter = 0;
            int years = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 + (toyCounter - 1) * 10;
                    years++;
                }
                else
                {
                    toyCounter++;
                }

            }

            double allMoney = (money - years) + (toyCounter * toyPrice);
            if (allMoney >= price)
            {
                Console.WriteLine($"Yes! {(allMoney - price):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(price - allMoney):f2}");
            }




        }
    }
}
