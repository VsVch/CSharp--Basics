using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjetMovie = double.Parse(Console.ReadLine());
            int numPeople = int.Parse(Console.ReadLine());
            double priceOnePeople = double.Parse(Console.ReadLine());

            double decor = budjetMovie * 0.1;
            if (numPeople>150)
            {
                priceOnePeople = priceOnePeople - priceOnePeople * 0.1;
            }

            double sum = priceOnePeople * numPeople + decor;

            if (sum<=budjetMovie)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budjetMovie-sum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(sum-budjetMovie):f2} leva more.");
            }


        }
    }
}
