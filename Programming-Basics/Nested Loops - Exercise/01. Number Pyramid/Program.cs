using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 1;
            bool isis = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (br > n)
                    {

                        break;
                    }
                    Console.Write(br + " ");
                    br++;
                }



                Console.WriteLine();
            }







        }
    }
}
