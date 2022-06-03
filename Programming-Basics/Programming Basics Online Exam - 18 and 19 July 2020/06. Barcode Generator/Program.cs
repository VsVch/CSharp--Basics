using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());


            int f1 = firstNumber / 1000;
            int f2 = firstNumber / 100 % 10;
            int f3 = firstNumber / 10 % 10;
            int f4 = firstNumber % 10;

            int s1 = secondNumber / 1000;
            int s2 = secondNumber / 100 % 10;
            int s3 = secondNumber / 10 % 10;
            int s4 = secondNumber % 10;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int m = 1; m <=9; m++)
                        {
                            if ((i % 2 !=0) && i >=f1 && i <=s1)
                            {
                                if ((j %2 != 0 || j==1) && j>=f2 && j<= s2)
                                {
                                    if ((k % 2 != 0 || k == 1) && k >= f3 && k <= s3)
                                    {
                                        if ((m % 2 != 0 || m==1) && m >= f4 && m <= s4)
                                        {
                                            Console.Write(""+ i + j + k + m +" ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }







        }
    }
}
