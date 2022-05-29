using System;

namespace _05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int Back = 0;
            int Chest = 0;
            int Legs = 0;
            int Abs = 0;
            int ProteinShake = 0;
            int ProteinBar = 0;
            double workOut = 0;
            double protein = 0;


            for (int i = 0; i < num; i++)
            {

                string activiti = Console.ReadLine();
                switch (activiti)
                {

                    case "Back":
                        Back++;
                        break;
                    case "Chest":
                        Chest++;
                        break;
                    case "Legs":
                        Legs++;
                        break;
                    case "Abs":
                        Abs++;
                        break;
                    case "Protein shake":
                        ProteinShake++;
                        break;
                    case "Protein bar":
                        ProteinBar++;
                        break;


                    default:
                        break;
                }



            }


            workOut = Back + Chest + Legs + Abs;
            protein = ProteinBar + ProteinShake;

            workOut = workOut / num * 100;
            protein = protein / num * 100;
            Console.WriteLine($"{Back} - back");
            Console.WriteLine($"{Chest} - chest");
            Console.WriteLine($"{Legs} - legs");
            Console.WriteLine($"{Abs} - abs");
            Console.WriteLine($"{ProteinShake} - protein shake");
            Console.WriteLine($"{ProteinBar} - protein bar");
            Console.WriteLine($"{workOut:f2}% - work out");
            Console.WriteLine($"{protein:f2}% - protein");






        }
    }
}
