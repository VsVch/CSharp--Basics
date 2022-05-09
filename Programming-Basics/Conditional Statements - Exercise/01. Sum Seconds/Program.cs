using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

            int ft1 = int.Parse(Console.ReadLine());
            int ft2 = int.Parse(Console.ReadLine());
            int ft3 = int.Parse(Console.ReadLine());

            int sum = ft1 + ft2 + ft3;
            int min = sum / 60;
            int sec = sum % 60;
            if (sec<10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }


        }
    }
}
