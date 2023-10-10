namespace _18._Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int n = 1;

            while(n <= num)
            {
                Console.WriteLine(n);
                n = n * 2 + 1;
            }
        }
    }
}