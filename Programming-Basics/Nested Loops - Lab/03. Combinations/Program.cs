using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            int br = 0;

            for (int i1 = 0; i1 <= n; i1++)
            {
                for (int i2 = 0; i2 <= n; i2++)
                {
                    for (int i3 = 0; i3 <= n; i3++)
                    {
                        while (i1+i2+i3==n)
                        {
                            br++;
                            //Console.WriteLine(br);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(br);




        }
    }
}
