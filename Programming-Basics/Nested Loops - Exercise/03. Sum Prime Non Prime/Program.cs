﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sums_prime_and_non_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = string.Empty;
            string input = Console.ReadLine();

            int sumprime = 0;
            int sumnoprime = 0;

            while (input != "stop")
            {
                bool isprime = true;
                int n = int.Parse(input);
                if (n < 0)
                {
                    n = 0;
                    Console.WriteLine("Number is negative.");

                }

                else if (n == 1)
                {
                    isprime = false;
                    sumnoprime += n;
                }
                else
                {
                    for (int count = 2; count <= n; count++)
                    {
                        if (n % count == 0 && count != n)

                        {
                            isprime = false;
                            sumnoprime += n;
                            break;
                        }
                    }

                }
                if (isprime)
                {
                    sumprime += n;
                }

                input = Console.ReadLine();
            }
            if (input == "stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {sumprime}");
                Console.WriteLine($"Sum of all non prime numbers is: {sumnoprime}");
            }
        }
    }
}