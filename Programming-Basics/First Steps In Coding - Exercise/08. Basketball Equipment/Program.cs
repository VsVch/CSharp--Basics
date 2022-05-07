using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {


            double taksa = double.Parse(Console.ReadLine());

            double kecove = taksa - taksa * 0.4;
            double ekip = kecove - kecove * 0.2;
            double topka = ekip / 4;
            double akse = topka / 5;

            double sum = taksa + kecove + ekip + akse+ topka;
            Console.WriteLine($"{sum}");


            Console.WriteLine(kecove);
            Console.WriteLine(ekip);
            Console.WriteLine(topka);
            Console.WriteLine(akse);



        }
    }
}
