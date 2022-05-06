using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());

            double sum = kvm * 7.61;
            double discount = sum * 18 / 100;
            sum = sum - discount;

            Console.WriteLine($"The final price is: {sum:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");










        }
    }
}
