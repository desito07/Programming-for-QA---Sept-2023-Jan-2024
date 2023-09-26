using System;

namespace Coffee_Shop_with_Checks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();
            double price = 0.0;
            bool validOrder = true;

            if (drink == "tea")
            {
                price = 0.6;
            }
            else if (drink == "coffee")
            {
                price = 1;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                validOrder = false;
            }

            if(validOrder)
            {
                if (extra == "sugar")
                {
                    price += 0.4;
                }
                else if (extra == "no")
                {
                    price += 0.0;
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                    validOrder = false;
                }
            }

            if (validOrder)
            {
                Console.WriteLine($"Final price: ${price:f2}");
            }
 
        }
    }
}
