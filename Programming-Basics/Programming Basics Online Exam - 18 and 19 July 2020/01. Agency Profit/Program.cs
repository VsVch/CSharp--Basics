using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numAdult = int.Parse(Console.ReadLine());
            int numKids = int.Parse(Console.ReadLine());
            double netPriceAdult = double.Parse(Console.ReadLine());
            double taxes = double.Parse(Console.ReadLine());

            double netPriceKids = netPriceAdult - netPriceAdult * 0.7;
            netPriceAdult = netPriceAdult + taxes;
            netPriceKids = netPriceKids + taxes;
            double sum = netPriceKids * numKids + netPriceAdult * numAdult;

            double prfit = sum * 0.2;

            Console.WriteLine($"The profit of your agency from {name} tickets is {prfit:f2} lv.");





        }
    }
}
