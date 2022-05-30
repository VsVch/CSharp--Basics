using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {

            int kozunaci = int.Parse(Console.ReadLine());
            int koriQica = int.Parse(Console.ReadLine());
            int kgKurabii = int.Parse(Console.ReadLine());

            double sum = kozunaci * 3.2 + 4.35 * koriQica + kgKurabii * 5.4 + 0.15*12*koriQica;
            Console.WriteLine($"{sum:f2}");








        }
    }
}
