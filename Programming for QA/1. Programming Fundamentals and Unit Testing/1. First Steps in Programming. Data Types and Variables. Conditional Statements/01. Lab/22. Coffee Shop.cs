namespace Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();
            double price = 0.0;

            if(drink == "tea")
            {
                price = 0.6;
            }
            else if(drink == "coffee")
            {
                price = 1;
            }

            if(extra == "sugar")
            {
                price += 0.4;
            }
            Console.WriteLine($"Final price: ${price:f2}");

        }
    }
}