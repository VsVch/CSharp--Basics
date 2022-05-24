using System;

namespace _06._Movie_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for (int i = a1; i <= a2-1; i++)
            {

                char letar = (char)i;


                for (int j = 1; j <= n-1; j++)
                {
                    for (int k = 1; k <= (n/2-1); k++)






                    {


                       

                        if (i%2==1 && (i+k+j)%2==1)
                        {
                            Console.WriteLine($"{letar}-{j}{k}{i}");
                        }
                    }
                }


            }

        }
    }
}
