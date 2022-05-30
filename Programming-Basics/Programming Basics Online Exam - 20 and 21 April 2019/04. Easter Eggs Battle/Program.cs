using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {

            int numEggsFirstPlayer = int.Parse(Console.ReadLine());
            int numEggsSecondPlayer = int.Parse(Console.ReadLine());
            string imput = Console.ReadLine();
            int coutFirstPlayer = 0;
            int coutSecondPlayer = 0;
            
            while (imput != "End of battle")
            {
                
                if (imput == "one")
                {
                    
                    numEggsSecondPlayer--;
                    
                }
                else if (imput == "two")
                {
                    numEggsFirstPlayer--;
                    
                }

                if (numEggsFirstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {numEggsSecondPlayer} eggs left.");

                    break;

                }
                else if (numEggsSecondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {numEggsFirstPlayer} eggs left.");

                    break;

                }





                imput = Console.ReadLine();
            }


            if (imput == "End of battle")
            {
                Console.WriteLine($"Player one has {numEggsFirstPlayer - coutFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {numEggsSecondPlayer - coutSecondPlayer} eggs left.");

            }





        }
    }
}
