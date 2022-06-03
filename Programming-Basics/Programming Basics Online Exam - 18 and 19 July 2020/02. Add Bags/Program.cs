using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {


            double priceMoreThen20 = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numBagadjes = int.Parse(Console.ReadLine());
            double price = 0;

            if (weight< 10)
            {
                price = priceMoreThen20 * 0.2;
            }
            else if (weight >=10 && weight <= 20)
            {
                price = priceMoreThen20 / 2;
            }
            else
            {
                price = priceMoreThen20;
            }



            if (days>30)
            {
                price = price + price * 0.1;
            }
            else if (days<=30 && days >= 7)
            {
                price = price + price * 0.15;
            }
            else if (days<7)
            {
                price = price + price * 0.4;
            }
            Console.WriteLine($"The total price of bags is: {numBagadjes*price:f2} lv.");
        
            
        }
    }
}
