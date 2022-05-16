using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            double sum = 0.0;

            while (input != "NoMoreMoney")
            {

                double mount = double.Parse(input);
                if (mount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }


                sum += mount;
                Console.WriteLine($"Increase: {mount:f2}");
                input = Console.ReadLine();


            }
            Console.WriteLine($"Total: {sum:f2}");







        }
    }
}
