using System;

namespace _04._Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            double chekBudjet = budjet;

            string nameAktor = Console.ReadLine();
            double allActors = 0;
            

            while (nameAktor != "ACTION")
            {

                double payOneAktor = 0;

                if (nameAktor.Length <= 15)
                {
                    payOneAktor = double.Parse(Console.ReadLine());
                }
                else
                {
                    payOneAktor = 0.2 * chekBudjet;
                }

                allActors += payOneAktor;
                chekBudjet -= payOneAktor;

                if (allActors > budjet)
                {
                    Console.WriteLine($"We need {(allActors-budjet):f2} leva for our actors.");
                    break;
                }


                nameAktor = Console.ReadLine();
            }


            if (nameAktor == "ACTION")
            {
                Console.WriteLine($"We are left with {(budjet-allActors):f2} leva.");
            }





        }
    }
}
