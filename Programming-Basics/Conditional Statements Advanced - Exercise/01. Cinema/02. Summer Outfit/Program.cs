using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {

            double degree = double.Parse(Console.ReadLine());

            string partOfDay = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";

            if (10 <= degree && degree <= 18)
            {
                if (partOfDay == "Morning")
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (partOfDay == "Afternoon")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (partOfDay == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            else if (18 < degree && degree <= 24)
            {
                if (partOfDay == "Morning")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (partOfDay == "Afternoon")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (partOfDay == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            else if (degree >= 25)
            {
                if (partOfDay == "Morning")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (partOfDay == "Afternoon")
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";
                }
                else if (partOfDay == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degree} degrees, get your {Outfit} and {Shoes}.");
        }
    }
}
