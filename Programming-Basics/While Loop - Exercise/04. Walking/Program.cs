using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            String input = "";
            int allSteps = 0;

            while (allSteps < 10000)
            { // докато не са достигнати желаните стъпки
                input = Console.ReadLine(); // четем вход от клавиатурата
                if ("Going home" == (input))
                { // ако има съвпадение
                    allSteps += int.Parse(Console.ReadLine()); // добавяме към общите стъпки, тези които ще извърви докато се прибере
                    break; // излизаме от цикъла
                }
                else
                { // ако прочетения вход са брой стъпки
                    allSteps += int.Parse(input); // обръщаме входа в число и го добавяме към изминатите крачки
                }
            }

            if (allSteps >= 10000)
            { // ако е достъгната целта
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{ allSteps - 10000} steps over the goal!");
            }
            else
            { // ако не е достигната целта
                Console.WriteLine($"{ 10000 - allSteps} more steps to reach goal.");
            }



        }
    }
}
