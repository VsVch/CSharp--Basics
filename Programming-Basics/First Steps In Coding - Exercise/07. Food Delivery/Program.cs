using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int numF = int.Parse(Console.ReadLine());
            int numFish = int.Parse(Console.ReadLine());
            int numVegan = int.Parse(Console.ReadLine());

            double sum = numF * 10.35 + numFish * 12.4 + numVegan * 8.15;
            double desert = sum * 0.2;


            sum = sum + desert + 2.5;
            Console.WriteLine(sum);

        }
    }
}
