using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double oblekloZaOne = double.Parse(Console.ReadLine());

            double dekor = budjet * 0.1;
            double sum = 0;
            

            if (statisti >= 150)
            {
                sum = (statisti * oblekloZaOne) - (statisti * oblekloZaOne )* 0.1;
            }
            else
            {
                sum = statisti * oblekloZaOne ;
            }


            sum = sum + dekor;
            if (budjet >= sum)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {(budjet-sum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(sum-budjet):f2} leva more.");
            }


        }
    }
}
