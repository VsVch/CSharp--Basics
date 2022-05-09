using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min = min + 15;

            if (min >=60)
            {
                min = min - 60;
                hour = hour + 1;
            }
            if (hour >=24)
            {
                hour = hour - 24;
            }

            if (min < 10)
            {
                Console.WriteLine($"{hour}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hour}:{min}");
            }
        }
    }
}
