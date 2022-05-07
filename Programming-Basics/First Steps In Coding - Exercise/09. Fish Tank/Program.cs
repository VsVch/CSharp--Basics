using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int sh = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double per = double.Parse(Console.ReadLine());

            double obem = l * sh * h;
            obem = obem * 0.001;

            double nujda = obem * (1 - per / 100);
            Console.WriteLine(nujda);



        }
    }
}
