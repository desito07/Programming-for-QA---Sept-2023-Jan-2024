namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeScreening = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.00;
            double area = rows * columns;

            if (typeScreening == "Premiere")
            {
                price += area * 12.00;
            }
            else if(typeScreening == "Normal")
            {
                price += area * 7.5;
            }
            else if(typeScreening == "Discount")
            {
                price += area * 5.00;
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
