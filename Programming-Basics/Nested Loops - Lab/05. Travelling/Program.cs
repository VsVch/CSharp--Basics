using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string insert = Console.ReadLine();

            while (insert != "End")
            {
                double budjet = double.Parse(Console.ReadLine());

                double sum = 0;

                while (sum < budjet)
                {
                    sum += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {insert}!");
                insert = Console.ReadLine();
            }









        }
    }
}
