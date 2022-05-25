using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            double gorivo = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double priceGorivo = 2.1;
            double priceGid = 100;
            double discount = 0;

            if (day == "Saturday")
            {
                discount = 0.1;
            }
            else if (day == "Sunday")
            {
                discount = 0.2;
            }


            double razhodi = priceGorivo * gorivo + priceGid;
            razhodi = razhodi - razhodi * discount;

            


            if (budjet > razhodi )
            {
                Console.WriteLine($"Safari time! Money left: {(budjet-razhodi):f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {(razhodi-budjet):f2} lv.");
            }
        }
    }
}
