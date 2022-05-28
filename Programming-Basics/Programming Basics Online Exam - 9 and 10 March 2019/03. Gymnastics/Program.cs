using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {

            string coutry = Console.ReadLine();
            string ured = Console.ReadLine();
            double t = 0;
            double i = 0;
            switch (coutry)
            {
                case "Russia":
                    switch (ured)
                    {
                        case "ribbon":
                            t = 9.1;
                            i = 9.4;
                            break;
                        case "hoop":
                            t = 9.3;
                            i = 9.8;
                            break;
                        case "rope":
                            t = 9.6;
                            i = 9.0;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Bulgaria":
                    switch (ured)
                    {
                        case "ribbon":
                            t = 9.6;
                            i = 9.4;
                            break;
                        case "hoop":
                            t = 9.55;
                            i = 9.75;
                            break;
                        case "rope":
                            t = 9.5;
                            i = 9.4;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Italy":
                    switch (ured)
                    {
                        case "ribbon":
                            t = 9.2;
                            i = 9.5;
                            break;
                        case "hoop":
                            t = 9.45;
                            i = 9.35;
                            break;
                        case "rope":
                            t = 9.7;
                            i = 9.15;
                            break;

                        default:
                            break;
                    }
                    break;



                default:
                    break;
            }


            double sum = t + i;
            double per = 20 - sum;
            per = per / 20 * 100;


            Console.WriteLine($"The team of {coutry} get {sum:f3} on {ured}.");
            Console.WriteLine($"{per:f2}% ");
        }
    }
}
