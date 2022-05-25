using System;

namespace qwe123
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractDuration = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            double taxesForMonth = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (contractDuration)
            {
                case "one":
                    {
                        if (contractType == "Small" && internet == "yes")
                        {
                            price = (9.98 + 5.50) * taxesForMonth;
                        }
                        else if (contractType == "Small" && internet == "no")
                        {
                            price = 9.98 * taxesForMonth;

                        }
                        if (contractType == "Middle" && internet == "yes")
                        {
                            price = (18.99 + 4.35) * taxesForMonth;
                        }
                        else if (contractType == "Middle" && internet == "no")
                        {
                            price = 18.99 * taxesForMonth;

                        }
                        if (contractType == "Large" && internet == "yes")
                        {
                            price = (25.98 + 4.35) * taxesForMonth;
                        }
                        else if (contractType == "Large" && internet == "no")
                        {
                            price = 25.98 * taxesForMonth;

                        }
                        if (contractType == "ExtraLarge" && internet == "yes")
                        {
                            price = (35.99 + 3.85) * taxesForMonth;
                        }
                        else if (contractType == "ExtraLarge" && internet == "no")
                        {
                            price = 35.99 * taxesForMonth;

                        }

                        Console.WriteLine($"{price:F2} lv.");
                        break;
                    }
                case "two":
                    {
                        if (contractType == "Small" && internet == "yes")
                        {
                            price = (8.58 + 5.50) * taxesForMonth;
                        }
                        else if (contractType == "Small" && internet == "no")
                        {
                            price = 8.58 * taxesForMonth;

                        }
                        if (contractType == "Middle" && internet == "yes")
                        {
                            price = (17.09 + 4.35) * taxesForMonth;
                        }
                        else if (contractType == "Middle" && internet == "no")
                        {
                            price = 17.09 * taxesForMonth;

                        }
                        if (contractType == "Large" && internet == "yes")
                        {
                            price = (23.59 + 4.35) * taxesForMonth;
                        }
                        else if (contractType == "Large" && internet == "no")
                        {
                            price = 23.59 * taxesForMonth;

                        }
                        if (contractType == "ExtraLarge" && internet == "yes")
                        {
                            price = (31.79 + 3.85) * taxesForMonth;
                        }
                        else if (contractType == "ExtraLarge" && internet == "no")
                        {
                            price = 31.79 * taxesForMonth;

                        }

                        double overallprice = price - (price * 0.0375);
                        Console.WriteLine($"{overallprice:F2} lv.");

                        break;

                    }
            }

        }
    }
}