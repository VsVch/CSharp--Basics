using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {


            string etap = Console.ReadLine();
            string kindTicket = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());
            double price = 0;

            switch (etap)
            {
                case "Quarter final":
                    switch (kindTicket)
                    {

                        case "Standard":
                            price = 55.5;
                            break;
                        case "Premium":
                            price = 105.2;
                            break;
                        case "VIP":
                            price = 118.9;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Semi final":
                    switch (kindTicket)
                    {

                        case "Standard":
                            price = 75.8;
                            break;
                        case "Premium":
                            price = 125.22;
                            break;
                        case "VIP":
                            price = 300.4;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Final":
                    switch (kindTicket)
                    {

                        case "Standard":
                            price = 110.1;
                            break;
                        case "Premium":
                            price = 160.66;
                            break;
                        case "VIP":
                            price = 400;
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }

            double sum = numTickets * price;
            if (sum>4000)
            {
                sum = sum - sum * 0.25;
                letter = 'N';
            }
            else if (sum>2500)
            {
                sum = sum - sum * 0.1;
            }


            if (letter == 'Y')

            {
                sum = sum + numTickets * 40;
            }

            Console.WriteLine($"{sum:f2}");






        }
    }
}
