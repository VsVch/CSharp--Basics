using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double priceForRoses = 5;
            double priceForDahlias = 3.8;
            double priceForTulips = 2.8;
            double priceForNarcissus = 3;
            double priceForGladiolus = 2.5;
           // double discount = 0;
            double moneyForFlowers = 0;

            if (typeOfFlowers == "Roses")
            {

                if (countOfFlowers > 80)
                {
                    moneyForFlowers = priceForRoses - priceForRoses*10/100;
                }
                else
                {
                    moneyForFlowers = priceForRoses;
                }


                //moneyForFlowers = countOfFlowers * priceForRoses * discount;
                
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (countOfFlowers > 90)
                {
                    moneyForFlowers = priceForDahlias - priceForDahlias*15/100;
                }
                else
                {
                    moneyForFlowers = priceForDahlias;
                }


               // moneyForFlowers = countOfFlowers * priceForDahlias * discount;
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (countOfFlowers > 80)
                {
                    moneyForFlowers = priceForTulips - priceForTulips*15/100;
                }
                else
                {
                    moneyForFlowers = priceForTulips;
                }


                //moneyForFlowers = countOfFlowers * priceForTulips * discount;
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (countOfFlowers < 120)
                {
                    moneyForFlowers = priceForNarcissus + priceForNarcissus*15/100;
                }
                else
                {
                    moneyForFlowers = priceForNarcissus;
                }


               // moneyForFlowers = countOfFlowers * priceForNarcissus * discount;
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (countOfFlowers < 80)
                {
                    moneyForFlowers = priceForGladiolus + priceForGladiolus*20/100;
                }
                else
                {
                    moneyForFlowers = priceForGladiolus;
                }


                //moneyForFlowers = countOfFlowers * moneyForFlowers;
            }

            moneyForFlowers = countOfFlowers * moneyForFlowers;
            if (budjet >= moneyForFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {(budjet - moneyForFlowers):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyForFlowers - budjet):f2} leva more.");
            }

           


        }
    }
}
