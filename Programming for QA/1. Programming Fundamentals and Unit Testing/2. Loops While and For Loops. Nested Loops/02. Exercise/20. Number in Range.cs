namespace _20._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 100)
                {
                    break;
                }
 
            }
            Console.WriteLine(num);
        }
    }
}