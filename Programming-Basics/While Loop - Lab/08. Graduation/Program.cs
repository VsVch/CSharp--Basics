using System;

namespace _5._8Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int klas = 12;
            int broi = 0;
            int broyach = 0;
            int broyacha = 1;
            double obshto = 0;
            while (broi < klas)
            {
                double depozit = double.Parse(Console.ReadLine());

                if (depozit < 4.00)
                {
                    broyach++;
                    if (broyach > broyacha)
                    {
                        Console.WriteLine($"{name} has been excluded at {broyach - 2} grade");
                        break;
                    }
                    //continue;   
                }
                broi++;
                broyacha++;
                broyach++;
                obshto += depozit;
            }
            if (broi == klas)
            {
                obshto = obshto / 12;
                Console.WriteLine($"{name} graduated. Average grade: {obshto:F2}");
            }
        }
    }
}


