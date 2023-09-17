namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numChickens = int.Parse(Console.ReadLine());
            int numFish = int.Parse(Console.ReadLine());
            int numVegs = int.Parse(Console.ReadLine());

            double priceChicken = numChickens * 10.35;
            double priceFish = numFish * 12.40;
            double priceVegs = numVegs * 8.15;

            double priceTotal = priceChicken + priceFish + priceVegs;
            double priceDessert = priceTotal * 0.2;
            double priceUpdated = priceTotal + priceDessert;
            Console.WriteLine(priceUpdated + 2.50);
         }
    }
}
