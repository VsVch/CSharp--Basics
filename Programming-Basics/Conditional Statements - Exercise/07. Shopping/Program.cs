using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int procesor = int.Parse(Console.ReadLine());
            int ramMemori = int.Parse(Console.ReadLine());


            

            double sum = videoCards * 250;

            double priceProcesor = sum * 0.35;
            double priceRamMemori = sum * 0.1;


           



            double total = sum + procesor * priceProcesor + ramMemori*priceRamMemori;

            //Console.WriteLine(sum);
           // Console.WriteLine(total);

            if (videoCards>procesor)
            {
                total = total - total * 0.15;
            }

            
            if (total<=budjet)
            {
                Console.WriteLine($"You have {(budjet-total):f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {(total-budjet):f2} leva more!");
            }

        }
    }
}
