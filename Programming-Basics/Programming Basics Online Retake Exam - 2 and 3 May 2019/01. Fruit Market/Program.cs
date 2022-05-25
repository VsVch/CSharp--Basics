using System;

namespace _01._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceQgodi = double.Parse(Console.ReadLine());
            double banani = double.Parse(Console.ReadLine());
            double portokali = double.Parse(Console.ReadLine());
            double malini = double.Parse(Console.ReadLine());
            double qgodi = double.Parse(Console.ReadLine());

            double priceMalini = priceQgodi / 2;
            double pricePortokali = priceMalini * 0.6;
            double priceBananas = priceMalini * 0.2;

            double sum = priceQgodi * qgodi + banani * priceBananas + portokali * pricePortokali + malini * priceMalini;

            

            Console.WriteLine($"{sum}");




        }
    }
}
