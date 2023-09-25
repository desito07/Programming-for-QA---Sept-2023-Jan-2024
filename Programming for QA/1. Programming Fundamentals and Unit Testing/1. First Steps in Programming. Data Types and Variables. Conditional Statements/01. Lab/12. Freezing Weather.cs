namespace _12. Freazing Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("Freazing weather!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}   }