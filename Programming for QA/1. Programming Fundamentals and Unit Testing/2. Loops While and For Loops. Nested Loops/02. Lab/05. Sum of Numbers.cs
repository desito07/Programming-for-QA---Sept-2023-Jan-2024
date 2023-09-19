namespace _05._Sum_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; sum < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}