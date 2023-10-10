namespace _02._1_To_N_Reversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}