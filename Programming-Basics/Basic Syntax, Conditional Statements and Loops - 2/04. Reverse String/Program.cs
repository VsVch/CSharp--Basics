using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string reName = string.Empty;
            for (int i = name.Length - 1; i >= 0 ; i--)
            {
                reName += name[i];
            }
            Console.WriteLine(reName);




        }
    }
}
