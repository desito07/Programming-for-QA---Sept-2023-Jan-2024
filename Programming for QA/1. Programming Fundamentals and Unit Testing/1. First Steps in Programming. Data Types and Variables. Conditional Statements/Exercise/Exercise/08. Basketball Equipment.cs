namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int feeAnnual = int.Parse(Console.ReadLine());
            double sneakersPrice = feeAnnual - (feeAnnual * 0.4);
            double teamPrice = sneakersPrice - (sneakersPrice * 0.20);
            double ballPrice = teamPrice * 0.25;
            double accessoriesPrice = ballPrice * 0.2;
            Console.WriteLine(feeAnnual + sneakersPrice + teamPrice + ballPrice + accessoriesPrice);
        }
    }
}
