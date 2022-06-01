using System;

namespace _02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {


            double gusts = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            double kozunaci = 0;
            kozunaci = (gusts / 3);
            kozunaci = Math.Ceiling(kozunaci);
            double qica = gusts * 2;
            double sum = kozunaci * 4 + qica * 0.45;
            double raz = Math.Abs(budjet - sum);
            if (budjet>=sum)
            {
                Console.WriteLine($"Lyubo bought {kozunaci} Easter bread and {qica} eggs.");
                Console.WriteLine($"He has {raz:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {raz:f2} lv. more.");
            }
            

            




        }
    }
}
