using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTickets = 0;
            double studen = 0;
            double standar = 0;
            double kid = 0;
            string movie = Console.ReadLine();

            while (movie != "Finish")
            {

                double capacity = double.Parse(Console.ReadLine());

                double numOfTickets = 0;

                while (numOfTickets < capacity )
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "standard":
                            standar++;
                            break;
                        case "student":
                            studen++;
                            break;
                        case "kid":
                            kid++;
                            break;
                            
                        
                        
                        
                    }

                    numOfTickets++; 

                }
                totalTickets += numOfTickets;
                Console.WriteLine($"{movie} - {numOfTickets/capacity*100:f2}% full.");
                movie = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studen/totalTickets*100:f2}% student tickets.");
            Console.WriteLine($"{standar/totalTickets*100:f2}% standard tickets.");
            Console.WriteLine($"{kid/totalTickets*100:f2}% kids tickets.");

        }
    }
}
