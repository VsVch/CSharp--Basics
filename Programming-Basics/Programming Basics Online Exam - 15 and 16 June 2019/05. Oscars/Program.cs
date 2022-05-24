using System;

namespace _05._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jure = int.Parse(Console.ReadLine());
            double pointForActor = 0;
            double sum = 0;
            sum = points;

            for (int i = 0; i < jure; i++)
            {
                string nameJure = Console.ReadLine();
                
                double pointFromJure = double.Parse(Console.ReadLine());

                pointForActor = nameJure.Length * pointFromJure / 2;

               

                sum += pointForActor;
                if (sum>=1250)
                {
                    break;
                }
               
            }

            //sum = points + pointForActor;
            if (sum >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameActor} you need {(1250.5-sum):f1} more!");
        
            }

            


        }
    }
}
