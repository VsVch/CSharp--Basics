using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string sait = Console.ReadLine();

                if (sait == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (sait == "Instagram")
                {
                    salary = salary - 100;
                }
                else if (sait == "Reddit")
                {
                    salary = salary - 50;
                }



                if (salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");

                    return;

                }


            }


            Console.WriteLine(salary);

        }
    }
}
