using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double s = 0.00;
            if (a == "square")
            {
                double i = double.Parse(Console.ReadLine());
                s = i * i;
                Console.WriteLine("{0:F3}",s);
            }
            else if (a == "rectangle")
            {
                double i1 = double.Parse(Console.ReadLine());
                double i2 = double.Parse(Console.ReadLine());
                s = i1 * i2;
                Console.WriteLine("{0:F3}", s);
            }
            else if (a == "circle")
            {
                double i = double.Parse(Console.ReadLine());
                s = i * i* Math.PI;
                Console.WriteLine("{0:F3}", s);
            }
            else if (a == "triangle")
            {
                double i1 = double.Parse(Console.ReadLine());
                double i2 = double.Parse(Console.ReadLine());
                s = (i1 * i2/2);
                Console.WriteLine("{0:F3}", s);
            }

        }
    }
}
