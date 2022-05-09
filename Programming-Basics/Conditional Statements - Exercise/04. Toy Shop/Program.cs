using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceHolyday = double.Parse(Console.ReadLine());
            int pyzels = int.Parse(Console.ReadLine());
            int speakingDoll = int.Parse(Console.ReadLine());
            int tedyBear = int.Parse(Console.ReadLine());
            int minioni = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());

            double sum = pyzels * 2.6 + speakingDoll * 3 + tedyBear * 4.1 + minioni * 8.2 + tracks * 2;


            int sumToys = pyzels + speakingDoll + tedyBear + minioni + tracks;

            //double discount = 0;
            if (sumToys>=50)
            {
                //discount = 0.25;
                sum = sum - sum*0.25;
                sum = sum - sum * 0.1;
            }
            else
            {
                sum = sum - sum * 0.1;
            }

            if (sum>=priceHolyday)
            {
                Console.WriteLine($"Yes! {(sum-priceHolyday):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceHolyday-sum):f2} lv needed.");
            }

        }
    }
}
