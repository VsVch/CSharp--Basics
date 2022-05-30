using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int numGusts = int.Parse(Console.ReadLine());
            double cuvertForOne = double.Parse(Console.ReadLine());
            double budjetDesi = double.Parse(Console.ReadLine());
            budjetDesi = budjetDesi - budjetDesi * 0.1;
            double discount = 0;
            double sum = 0;
            double raz = 0;

            if (numGusts >= 10 && numGusts <= 15)
            {
                discount = 0.15;
            }
            else if (numGusts >15 && numGusts <= 20)
            {
                discount = 0.2;
            }
            else if (numGusts > 20)
            {
                discount = 0.25;
            }

            sum = numGusts * cuvertForOne - numGusts * cuvertForOne * discount;
            raz = Math.Abs(budjetDesi-sum);
            if (budjetDesi >= sum)
            {
                Console.WriteLine($"It is party time! {raz:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {raz:f2} leva needed.");
            }


        }
    }
}
