using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {


            string name = string.Empty;

            string winName = string.Empty;
            double maxPoints = 0;
            while ("Stop" != (name = Console.ReadLine()))
            {
                double points = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());


                    if (num == name[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }

                    if (maxPoints <= points)
                    {
                        winName = name;
                        maxPoints = points;
                    }


                }


            }

            Console.WriteLine($"The winner is {winName} with {maxPoints} points!");


        }
    }
}
