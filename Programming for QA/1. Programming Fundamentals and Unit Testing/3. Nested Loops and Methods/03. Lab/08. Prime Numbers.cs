namespace _08._Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for(int currentNum = start; currentNum <= end; currentNum++)
            {
                bool isPrime = true;
                int divider = 2;

                while(divider < end)
                {
                    if(currentNum == divider)
                    {
                        divider++;
                        continue;
                    }
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider++;
                }

                if(isPrime )
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}