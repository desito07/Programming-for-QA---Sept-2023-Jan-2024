namespace _13._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double current = double.Parse(Console.ReadLine());

                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}