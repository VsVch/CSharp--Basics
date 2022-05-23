using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {

            double naem = double.Parse(Console.ReadLine());

            double statuetki = naem - naem * 0.3;
            double ketaring = statuetki - statuetki * 0.15;
            double ozvuchavane = ketaring / 2;
            double sum = naem + statuetki + ketaring + ozvuchavane;
            Console.WriteLine($"{sum:f2}");

        }
    }
}
