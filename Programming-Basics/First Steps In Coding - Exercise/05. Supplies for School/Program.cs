using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {

            int packetPen = int.Parse(Console.ReadLine());
            int pacletMarkeri = int.Parse(Console.ReadLine());
            int litri = int.Parse(Console.ReadLine());
            int per = int.Parse(Console.ReadLine());

            double sum = packetPen * 5.8 + pacletMarkeri * 7.2 + litri * 1.2;
            sum = sum - sum * per / 100;
            Console.WriteLine(sum);





        }
    }
}
