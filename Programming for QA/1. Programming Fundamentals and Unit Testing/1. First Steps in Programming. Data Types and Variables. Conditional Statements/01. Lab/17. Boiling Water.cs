namespace Boiling_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if(num > 100)
            {
                Console.WriteLine($"The water is boiling");
            }
            else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}