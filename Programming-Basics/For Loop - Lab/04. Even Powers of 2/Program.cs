using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int n = 1;

            for (int i = 0; i <= num; i += 2)
            {
                Console.WriteLine(n);
                n = 2 * 2 * n;
            }








        }
    }
}
