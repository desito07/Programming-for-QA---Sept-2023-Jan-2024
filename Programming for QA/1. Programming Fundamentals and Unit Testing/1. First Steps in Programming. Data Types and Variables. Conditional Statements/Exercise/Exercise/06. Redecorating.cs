namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursCraftman = int.Parse(Console.ReadLine());

            double nylonCosts = (nylon + 2) * 1.50;
            double paintCosts = paint * 1.1 * 14.50;
            double thinnerCosts = (thinner * 5.00);
            double bagsCosts = 0.40;
            double totalCosts = nylonCosts + paintCosts + thinnerCosts + bagsCosts;
            double costsCrafman = (totalCosts * 0.3) * hoursCraftman;
            double finalCosts = totalCosts + costsCrafman;
            Console.WriteLine(finalCosts);
        }
    }
}
