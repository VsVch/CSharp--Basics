using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {


            int hall = int.Parse(Console.ReadLine());
            string numPeople = Console.ReadLine();
            int num = 0;
            int allNum = 0;
            double incom = 0;
            double allIncom = 0;

            while (true)
            {
                if (numPeople == "Movie time!")
                {

                    Console.WriteLine($"There are {hall-allNum} seats left in the cinema.");
                    break;
                }
                else
                {
                    num = int.Parse(numPeople);
                    hall -= num;
                    //allNum += num;

                    if (hall < 0)
                    {
                        Console.WriteLine($"The cinema is full.");
                        break;
                    }


                    if (num%3==0)
                    {
                        incom = 5 * num  -5;
                    }
                    else
                    {
                        incom = 5 * num;
                    }

                    allIncom += incom;
                    numPeople = Console.ReadLine();


                }



            }

            Console.WriteLine($"Cinema income - {allIncom} lv.");





        }
    }
}
