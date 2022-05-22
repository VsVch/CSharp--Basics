using System;

namespace _03._Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            string paket = Console.ReadLine();
            string vip = Console.ReadLine();
            double days = int.Parse(Console.ReadLine());
            double price = 0;


            if ((town == "Bansko" || town == "Borovets" || town == "Varna" || town == "Burgas") && (paket == "noEquipment" || paket == "withEquipment" || paket == "withBreakfast" || paket == "noBreakfast"))
            {
                switch (town)
                {
                    case "Bansko":
                    case "Borovets":
                        if (paket == "noEquipment")
                        {
                            price = 80;
                            if (vip == "yes")
                            {
                                price = price * 0.95;
                            }
                        }
                        else if (paket == "withEquipment")
                        {
                            price = 100;
                            if (vip == "yes")
                            {
                                price = price * 0.9;
                            }
                        }
                        break;
                    case "Varna":
                    case "Burgas":
                        if (paket == "noBreakfast")
                        {
                            price = 100;
                            if (vip == "yes")
                            {
                                price = price * 0.93;
                            }
                        }
                        else if (paket == "withBreakfast")
                        {
                            price = 130;
                            if (vip == "yes")
                            {
                                price = price * 0.88;
                            }
                        }


                        break;


                    default:
                        Console.WriteLine($"Invalid input!");
                        return;
                }

                if (days > 7)
                {
                    days = days - 1;
                }

                double sum = days * price;


                if (days <= 0)
                {
                    Console.WriteLine($"Days must be positive number!");
                }
                else
                {
                    Console.WriteLine($"The price is {sum:f2}lv! Have a nice time!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid input!");
            }
        

            
                


            

        }
    }
}
