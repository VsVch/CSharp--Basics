using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {

            int numEggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxNumber = 0;
            string maxColour = string.Empty;


            while (numEggs != 0)
            {
                string colour = Console.ReadLine();


                switch (colour)
                {
                    case "red":
                        redEggs++;
                        break;
                    case "orange":
                        orangeEggs++;
                        break;
                    case "blue":
                        blueEggs++;
                        break;
                    case "green":
                        greenEggs++;
                        break;

                    default:
                        break;
                }

                numEggs--;

            }

            



            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            if (redEggs > maxNumber)
            {
                maxNumber = redEggs;
                maxColour = "red";
            }
            if (orangeEggs > maxNumber)
            {
                maxNumber = orangeEggs;
                maxColour = "orange";
            }
            if (blueEggs > maxNumber)
            {
                maxNumber = blueEggs;
                maxColour = "blue";
            }
            if (greenEggs > maxNumber)
            {
                maxNumber = greenEggs;
                maxColour = "green";
            }



            Console.WriteLine($"Max eggs: {maxNumber} -> {maxColour}");

        }


    }
}
