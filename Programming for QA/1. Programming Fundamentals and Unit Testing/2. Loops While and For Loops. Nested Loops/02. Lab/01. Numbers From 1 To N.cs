namespace _01._Numbers_From_1_To_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}