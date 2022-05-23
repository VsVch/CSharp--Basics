using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {



            string movieName = string.Empty;
            double student = 0;
            double standard = 0;
            double kid = 0;
            double seats = 0;
            double seatsInOnesHall = 0;


            while (true)
            {
                string imput = Console.ReadLine();

                if (imput == "Finish")
                {
                    break;
                }
                else
                {
                    movieName = imput;
                    int freePlacesInHall = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= freePlacesInHall; i++)
                    {

                        
                        string typeTickets = Console.ReadLine();


                        

                        if (typeTickets == "End")
                        {
                            Console.WriteLine($"{movieName} - { seatsInOnesHall/ freePlacesInHall*100:f2}% full.");
                            
                            seatsInOnesHall = 0;
                            break;
                        }

                        else
                        {
                            seats++;
                            seatsInOnesHall++;

                            if (typeTickets == "student")
                            {
                                student++;
                            }
                            else if (typeTickets == "standard")
                            {
                                standard++;
                            }
                            else if (typeTickets == "kid")
                            {
                                kid++;
                            }
                        }



                        if (seatsInOnesHall >= freePlacesInHall)
                        {
                            Console.WriteLine($"{movieName} - {  seatsInOnesHall / freePlacesInHall * 100:f2}% full.");

                            seatsInOnesHall = 0;
                            break;
                        }


                    }

                    

                   
                }
                
            }


            Console.WriteLine($"Total tickets: {seats}");
            Console.WriteLine($"{student/seats*100:f2}% student tickets.");
            Console.WriteLine($"{standard/seats*100:f2}% standard tickets.");
            Console.WriteLine($"{kid/seats*100:f2}% kids tickets.");
            




        }
    }
}