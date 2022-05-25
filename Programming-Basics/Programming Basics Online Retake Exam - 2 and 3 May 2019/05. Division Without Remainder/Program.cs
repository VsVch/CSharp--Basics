using System;

namespace _05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double num = 0;
            double num4 = 0;
            double num3 = 0;
            double num2 = 0;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                sum++;

                if (num%4==0)
                {
                    num4++;
                    
                }
                if (num%3==0)
                {
                    num3++;
                }
                if (num%2==0)
                {
                    num2++;
                }


            }


            double p1 = num2 / sum * 100;
            double p2 = num3 / sum * 100;
            double p3 = num4 / sum * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");






        }
    }
}
