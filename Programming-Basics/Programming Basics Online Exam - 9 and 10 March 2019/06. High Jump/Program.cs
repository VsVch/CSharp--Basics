using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {



            int desiredHeight = int.Parse(Console.ReadLine());
            int failTimes = 0;
            int totalJumpTimes = 0;
            bool stop = false;

            for (int actualHeight = desiredHeight - 30; actualHeight <= desiredHeight; actualHeight += 5)
            {

                for (int i = 1; i <= 3; i++)
                {

                    int jumpHeight = int.Parse(Console.ReadLine());
                    if (jumpHeight > actualHeight)
                    {

                        totalJumpTimes++;
                        failTimes = 0;
                        break;
                    }
                    else
                    {
                        failTimes++;
                        totalJumpTimes++;
                    }
                }

                if (failTimes == 3)
                {
                    Console.WriteLine($"Tihomir failed at {actualHeight}cm after {totalJumpTimes} jumps.");
                    return;

                }
            }

            if (stop == false)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {totalJumpTimes} jumps.");






            }
        }
    }
}