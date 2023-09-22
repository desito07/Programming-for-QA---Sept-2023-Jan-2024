namespace _05._Teaching_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePens = pens * 5.80;
            double priceMarkers = markers * 7.20;
            double priceLiters = liters * 1.20;
            double totalPrice = pricePens + priceMarkers + priceLiters;
            double finalPrice = totalPrice - (totalPrice * discount/100);
            Console.WriteLine(finalPrice);
        }
    }
}
