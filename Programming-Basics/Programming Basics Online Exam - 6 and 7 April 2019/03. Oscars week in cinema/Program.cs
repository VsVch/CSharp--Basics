using System;

namespace _03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameMovie = Console.ReadLine();
            string kindHall = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            double priceOneTicket = 0;

            switch (nameMovie)
            {

                case "A Star Is Born":
                    switch (kindHall)
                    {

                        case "normal":
                            priceOneTicket = 7.5;
                            break;
                        case "luxury":
                            priceOneTicket = 10.5;
                            break;
                        case "ultra luxury":
                            priceOneTicket = 13.5;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Bohemian Rhapsody":
                    switch (kindHall)
                    {

                        case "normal":
                            priceOneTicket = 7.35;
                            break;
                        case "luxury":
                            priceOneTicket = 9.45;
                            break;
                        case "ultra luxury":
                            priceOneTicket = 12.75;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Green Book":
                    switch (kindHall)
                    {

                        case "normal":
                            priceOneTicket = 8.15;
                            break;
                        case "luxury":
                            priceOneTicket = 10.25;
                            break;
                        case "ultra luxury":
                            priceOneTicket = 13.25;
                            break;
                        default:
                            break;
                    }
                    break;
                case "The Favourite":
                    switch (kindHall)
                    {

                        case "normal":
                            priceOneTicket = 8.75;
                            break;
                        case "luxury":
                            priceOneTicket = 11.55;
                            break;
                        case "ultra luxury":
                            priceOneTicket = 13.95;
                            break;
                        default:
                            break;
                    }
                    break;



                default:
                    break;
            }


            double sum = priceOneTicket * numTickets;
            Console.WriteLine($"{nameMovie} -> {$"{sum:f2}"} lv.");









        }
    }
}
