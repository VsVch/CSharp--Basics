using System;

namespace _06._Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0;
            

            for (int i = 1; i <= days; i++)
            {
                double curenSum = 0;
                for (int j = 1; j <= hours; j++)
                {
                    
                    if (i%2!=0&&j%2==0)
                    {
                        sum += 1.25;
                        curenSum += 1.25;
                    }
                    else if (i % 2 == 0 && j % 2 != 0)
                    {
                        sum += 2.5;
                        curenSum += 2.5;
                    }
                    else
                    {
                        sum += 1;
                        curenSum += 1;
                    }

                }
                Console.WriteLine($"Day: {i} - {curenSum:f2} leva");
            }



            // Console.WriteLine($"Day: {[i]} – { общата сума за деня} leva");

            Console.WriteLine($"Total: {sum:f2} leva");






        }
    }
}
