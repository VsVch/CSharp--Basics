using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {

            string favoritBook = Console.ReadLine();
            string nextBookName = Console.ReadLine();

            int counter = 0;
            bool isBookFound = false;

            while (nextBookName != "No More Books")
            {


                if (nextBookName == favoritBook)
                {
                    isBookFound = true;
                    break;
                }

                counter++;
                
                nextBookName = Console.ReadLine();
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");

               

            }



            
        }
    }
}
