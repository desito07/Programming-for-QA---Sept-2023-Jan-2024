namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double price = 0.00;
            double discount = 0.00;
            

            if(season == "Spring")
            {
                price = 3000;    
                if(count <= 6)
                {
                    discount = 0.1;
                    price -= discount * price;
                }
                else if(count >= 7 && count <= 11)
                {
                    discount = 0.15;
                    price  -= discount * price;
                }
                else if (count >= 12)
                {
                    discount = 0.25;
                    price -= discount * price;
                }
            }
            else if(season == "Summer")
            {
                price = 4200;
                if (count <= 6)
                {
                    discount = 0.1;
                    price -= discount * price;
                }
                else if (count >= 7 && count <= 11)
                {
                    discount = 0.15;
                    price -= discount * price;
                }
                else if (count >= 12)
                {
                    discount = 0.25;
                    price -= discount * price;
                }
            }
            else if (season == "Autumn")
            {
                price = 4200;
                if (count <= 6)
                {
                    discount = 0.1;
                    price -= discount * price;
                }
                else if (count >= 7 && count <= 11)
                {
                    discount = 0.15;
                    price -= discount * price;
                }
                else if (count >= 12)
                {
                    discount = 0.25;
                    price -= discount * price;
                }
            }
            else if (season == "Winter")
            {
                price = 2600;
                if (count <= 6)
                {
                    discount = 0.1;
                    price -= discount * price;
                }
                else if (count >= 7 && count <= 11)
                {
                    discount = 0.15;
                    price -= discount * price;
                }
                else if (count >= 12)
                {
                    discount = 0.25;
                    price -= discount * price;
                }
            }
            if(count %  2 == 0 && season != "Autumn")
            {
                discount = 0.05;
                price -= price * discount;
            }
            if(budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
            }

        }
    }
}