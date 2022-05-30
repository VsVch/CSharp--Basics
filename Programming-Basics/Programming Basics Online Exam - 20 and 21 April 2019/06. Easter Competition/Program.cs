using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCozunak = int.Parse(Console.ReadLine());
            string gradeAsString = string.Empty;
            string topShef = string.Empty;

            
            double maxChefGrades = 0;

            
            
            

            for (int i = 1; i <= numberOfCozunak; i++)
            {


                string nameOfChef = Console.ReadLine();

                gradeAsString = Console.ReadLine();
                int points = 0;
                
                while (gradeAsString != "Stop")
                {

                    int newPo = int.Parse(gradeAsString);

                    

                    points += newPo;

                    
                    gradeAsString = Console.ReadLine();
                }

                Console.WriteLine($"{nameOfChef} has {points} points.");

                if (points > maxChefGrades)
                {
                    maxChefGrades = points;
                    topShef = nameOfChef;
                    Console.WriteLine($"{topShef} is the new number 1!");

                }

                

                


               



            }
            Console.WriteLine($"{topShef} won competition with {maxChefGrades} points!");




        }
    }
}
