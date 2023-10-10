namespace _17._Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            while (num % 2 == 0)
            {
                num = int.Parse(Console.ReadLine());
            
            }
            Console.WriteLine(num);
        }
    }
}