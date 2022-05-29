using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double yearsPay = double.Parse(Console.ReadLine());

            double priceKecove = yearsPay - yearsPay * 0.4;
            double ekip = priceKecove - priceKecove * 0.2;
            double topka = ekip / 4;
            double aksesoari = topka / 5;

            double sum = yearsPay + priceKecove + ekip + topka + aksesoari;

            Console.WriteLine($"{sum:f2}");





        }
    }
}
