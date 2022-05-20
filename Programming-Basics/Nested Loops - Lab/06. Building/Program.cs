using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfBilding = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());

            for (int i1 = numberOfBilding; i1 >=1; i1--)
            {
                for (int i2 = 0; i2 <numberOfRooms; i2++)
                {
                    if (i1 == numberOfBilding)
                    {
                        Console.Write($"L{i1}{i2} ");
                        continue;
                    }
                    

                    if ( i1 % 2==0)
                    {
                        Console.Write($"O{i1}{i2} ");
                    }
                    else
                    {
                        Console.Write($"A{i1}{i2} ");
                    }

                   
                    
                }

                Console.WriteLine();
            }



            
        }
    }
}
