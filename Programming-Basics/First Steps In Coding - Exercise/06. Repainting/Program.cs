using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int litri = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());

            double sumNailon = (nailon + 2) * 1.5;
            double sumBoq = (litri + litri * 0.1) * 14.5;
            double sumRazreditl = razreditel * 5;
            double sumTorbi = 0.4;
            double sum = sumNailon + sumBoq + sumRazreditl + sumTorbi;
            double sumMaistori = sum * 0.3 * hour;
            Console.WriteLine((sum+sumMaistori));






        }
    }
}
