namespace _09._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int area = rows * columns;
            double price = 0.0;

            if(movieType == "Premiere")
            {
                price += area * 12.00;
            }
            else if(movieType == "Normal")
            {
                price += area * 7.50;
            }
            else if(movieType == "Discount")
            {
                price += area * 5.00;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}