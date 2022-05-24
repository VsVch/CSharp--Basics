using System;

namespace _03._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {

            string procekciq = Console.ReadLine();
            string movie = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            double price = 0;
            double allPrice = 0;


            if (procekciq == "John Wick")
            {
                if (movie == "Drink")
                {
                    price = 12;
                }
                else if (movie == "Popcorn")
                {
                    price = 15;
                }
                else if (movie == "Menu")
                {
                    price = 19;
                }
            }
            else if (procekciq == "Star Wars")
            {
                if (movie == "Drink")
                {
                    price = 18;
                }
                else if (movie == "Popcorn")
                {
                    price = 25;
                }
                else if (movie == "Menu")
                {
                    price = 30;
                }
            }
            else if (procekciq == "Jumanji")
            {
                if (movie == "Drink")
                {
                    price = 9;
                }
                else if (movie == "Popcorn")
                {
                    price = 11;
                }
                else if (movie == "Menu")
                {
                    price = 14;
                }
            }

            if (procekciq == "Star Wars" && numTickets >= 4)
            {
                price = price - price * 0.3;
                allPrice = numTickets * price;
                Console.WriteLine($"Your bill is {allPrice:f2} leva.");
            }

            else if (procekciq == "Jumanji" && numTickets == 2)
            {
                price = price - price * 0.15;
                allPrice = numTickets * price;
                Console.WriteLine($"Your bill is {allPrice:f2} leva.");
            }
            else
            {
                allPrice = numTickets * price;
                Console.WriteLine($"Your bill is {allPrice:f2} leva.");
            }
        }
    }
}
