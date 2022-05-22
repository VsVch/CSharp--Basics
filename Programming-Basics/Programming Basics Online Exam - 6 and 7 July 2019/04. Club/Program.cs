using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());

            double income = 0;
            double sum = 0;
            double price = 0;
            string input = Console.ReadLine();
            bool isT = false;
            while (input != "Party!")
            {
                price = input.Length;
                int num = int.Parse(Console.ReadLine());
                sum = price * num;
                if (sum % 2 != 0)
                {
                    sum = sum * 0.75;
                }


                income += sum;

                if (income >= profit)
                {
                    Console.WriteLine($"Target acquired.");
                    break;
                }



                input = Console.ReadLine();
            }
            if (input == "Party!")
            {
                Console.WriteLine($"We need {(profit - income):f2} leva more.");
                isT = true;

            }


            Console.WriteLine($"Club income - {income:f2} leva.");
            if (isT)
            {
                return;
            }

        }
    }
}