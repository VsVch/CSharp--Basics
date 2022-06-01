using System;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {

            double cenaKgBrashno = double.Parse(Console.ReadLine());
            double kgBrashno = double.Parse(Console.ReadLine());
            double kgZahar = double.Parse(Console.ReadLine());
            int koriQica = int.Parse(Console.ReadLine());
            int paketiMaq = int.Parse(Console.ReadLine());

            double cenaZahar = cenaKgBrashno - cenaKgBrashno * 0.25;
            double cenaQica = cenaKgBrashno + cenaKgBrashno * 0.1;
            double cenaMaq = cenaZahar - cenaZahar * 0.8;

            double sum = kgBrashno * cenaKgBrashno + kgZahar * cenaZahar + koriQica * cenaQica + paketiMaq * cenaMaq;
            Console.WriteLine($"{sum:f2}");






        }
    }
}
