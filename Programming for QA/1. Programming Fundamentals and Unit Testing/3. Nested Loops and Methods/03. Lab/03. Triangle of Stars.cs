namespace _03._Triangle_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int row = 1; row<= num; row++)
            {
                
                for(int j = 1; j <= row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}