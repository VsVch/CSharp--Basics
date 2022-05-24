using System;

namespace _05._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int numSeriali = int.Parse(Console.ReadLine());
            double sum = 0;
            double priceMovie = 0;
            for (int i = 0; i < numSeriali; i++)
            {
                string nameMovie = Console.ReadLine();


                priceMovie = double.Parse(Console.ReadLine());





                if (nameMovie == "Thrones")
                {
                    priceMovie = priceMovie * 0.5;
                }
                else if (nameMovie == "Lucifer")
                {
                    priceMovie = priceMovie - priceMovie * 0.4;
                }
                else if (nameMovie == "Protector")
                {
                    priceMovie = priceMovie - priceMovie * 0.3;
                }
                else if (nameMovie == "TotalDrama")
                {
                    priceMovie = priceMovie - priceMovie * 0.2;
                }
                else if (nameMovie == "Area")
                {
                    priceMovie = priceMovie - priceMovie * 0.1;
                }
                sum += priceMovie;
                





            }





            if (budjet >= sum)
            {
                Console.WriteLine($"You bought all the series and left with {(budjet - sum):f2} lv.");
                
            }
            else
            {
                Console.WriteLine($"You need {(sum - budjet):f2} lv. more to buy the series!");
                
            }






        }
    }
}
