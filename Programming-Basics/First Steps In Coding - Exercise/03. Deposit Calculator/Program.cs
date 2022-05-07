using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double dep = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());


            double sum = dep*per/100;
            sum = sum / 12;
            sum = dep + month * sum;
            Console.WriteLine($"{sum:f2}");



        }
    }
}
