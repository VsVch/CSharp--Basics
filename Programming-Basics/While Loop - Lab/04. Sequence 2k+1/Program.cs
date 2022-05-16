using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {



            int num = int.Parse(Console.ReadLine());

            int rezult = 1;

            while (num >= rezult)
            {

                Console.WriteLine(rezult);
                rezult = rezult * 2 + 1;

            }




        }
    }
}
