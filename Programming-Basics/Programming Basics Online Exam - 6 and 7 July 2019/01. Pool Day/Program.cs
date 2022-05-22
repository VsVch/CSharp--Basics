using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {

            int numPeople = int.Parse(Console.ReadLine());
            double taksaEmtrance = double.Parse(Console.ReadLine());
            double priceOneShezlong = double.Parse(Console.ReadLine());
            double priceAmbrela = double.Parse(Console.ReadLine());

            double price = numPeople * taksaEmtrance;
            double numShezlong = Math.Ceiling(numPeople*0.75);
            double allPriceShezlong = numShezlong * priceOneShezlong;
            double numAmbrela = Math.Ceiling(numPeople*0.5);
            double priceAllAmbrela = numAmbrela * priceAmbrela;
            double sumALL = price + allPriceShezlong + priceAllAmbrela;
            Console.WriteLine($"{sumALL:f2} lv.");











        }
    }
}
