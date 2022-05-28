using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {

            string first = Console.ReadLine();
            int win = 0;
            int lost = 0;
            int same = 0;
            if ((first[0]) > (first[2]))
            {
                win += 1;
            }
            else if ((first[0]) == (first[2]))
            {
                same += 1;
            }

            else
            {
                lost += 1;
            }






            string second = Console.ReadLine();

            if ((second[0]) > (second[2]))
            {
                win += 1;
            }
            else if ((second[0]) == (second[2]))
            {
                same += 1;
            }
            else
            {
                lost += 1;
            }

            string tirth = Console.ReadLine();

            if ((tirth[0]) > (tirth[2]))
            {
                win += 1;
            }
            else if ((tirth[0]) == (tirth[2]))
            {
                same += 1;
            }
            else
            {

                lost += 1;

            }


            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {same}");


        }
    }
}
