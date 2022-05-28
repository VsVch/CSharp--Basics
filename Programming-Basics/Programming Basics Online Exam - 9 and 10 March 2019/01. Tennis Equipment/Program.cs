using System;

namespace _01._Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceTenisRaketa = double.Parse(Console.ReadLine());
            int numTenisRaketi = int.Parse(Console.ReadLine());
            int maratonki = int.Parse(Console.ReadLine());


            double priceMaratonki = priceTenisRaketa / 6;
            double sum = priceTenisRaketa * numTenisRaketi + maratonki * priceMaratonki;
            double sum2 = sum * 0.2;
            double sum3 = sum + sum2;
            double jo = Math.Floor(sum3/8);
            double spon = Math.Ceiling(sum3*7/8);
            Console.WriteLine($"Price to be paid by Djokovic {jo}");
            Console.WriteLine($"Price to be paid by sponsors {spon}");









        }
    }
}
