using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 1;


            while (sum < num)
            {

                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;

            }
            Console.WriteLine(sum);




        }
    }
}
