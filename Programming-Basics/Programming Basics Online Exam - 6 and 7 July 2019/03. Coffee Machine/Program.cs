using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {

            string napitka = Console.ReadLine();
            string sugar = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double price = 0;

            switch (napitka)
            {
                    case "Espresso":
                    if (sugar == "Without")
                    {
                        price = 0.9;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.2;
                    }

                    break;
                    case "Cappuccino":
                    if (sugar == "Without")
                    {
                        price = 1;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1.2;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.6;
                    }
                    break;
                    case "Tea":
                    if (sugar == "Without")
                    {
                        price = 0.5;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 0.6;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 0.7;
                    }
                    break;




                default:
                    break;
            }



            if (sugar == "Without")
            {
                price = price * 0.65;
            }

            if (napitka == "Espresso" && num >= 5)
            {
                price = price * 0.75;
            }


            double sum = num * price;
            if (sum > 15)
            {
                sum = sum * 0.8;
            }


            Console.WriteLine($"You bought {num} cups of {napitka} for {sum:f2} lv.");


        }
    }
}
