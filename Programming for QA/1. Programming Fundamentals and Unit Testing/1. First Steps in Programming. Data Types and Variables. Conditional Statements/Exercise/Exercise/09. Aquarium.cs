namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double occupiedSpace = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLiters = volume / 1000;
            double requiredWater = volumeInLiters - (volumeInLiters * (occupiedSpace / 100));
            Console.WriteLine($"{requiredWater:f2}");
        }
    }
}
