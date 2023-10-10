namespace _16._Decreasing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            

            while(num >= 1)
            {

                Console.WriteLine(num);
                num--;
            }

            /*for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }*/

        }
    }
}