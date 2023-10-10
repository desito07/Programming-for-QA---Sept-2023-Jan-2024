namespace _12._First_N_Numbers_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++) 
            {
                current = i;

                if(current == 1)
                {
                    Console.Write(current);
                }
                else
                {
                    Console.Write("+" + current);
                }
                sum += current;             
            }
            Console.WriteLine("=" + sum);
            


        }
    }
}