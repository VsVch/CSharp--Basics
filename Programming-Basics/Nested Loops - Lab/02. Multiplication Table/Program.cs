using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int i1 = 1; i1 <=10; i1++)
                {
                    Console.WriteLine($"{i} * {i1} = {i*i1}");
                }
            }
        }
    }
}
