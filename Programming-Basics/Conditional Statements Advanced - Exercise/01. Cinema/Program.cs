using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0;
            int area = r * c;
            double price = 0;
            

            if (type == "Premiere")
            {
                price = 12;
            }
            else if (type == "Normal")
            {
                price = 7.5;
            }
            else if (type == "Discount")
            {
                price = 5;
            }

            income = area * price;
            Console.WriteLine($"{income:f2} leva");
            
        }
    }
}
