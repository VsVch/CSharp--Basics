using System;

namespace _01._Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {

            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceForTicket = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double priceForDay = tickets * priceForTicket;
            double sumForAll = days * priceForDay;
            double discount = sumForAll * percent / 100;
            double profit = sumForAll - discount;
            Console.WriteLine($"The profit from the movie {movie} is {profit:f2} lv.");




        }
    }
}
