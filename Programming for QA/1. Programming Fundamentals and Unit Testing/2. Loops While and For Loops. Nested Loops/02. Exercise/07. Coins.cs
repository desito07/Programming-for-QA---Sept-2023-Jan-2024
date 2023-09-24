namespace 07. Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int counter = 0;

            while (change > 0)
            {
            
                    if (change >= 2)
                    {
                        change -= 2;
                        counter++;
                    }
                    else if (change >= 1)
                    {
                        change -= 1;
                        counter++;
                    }
                    else if (change >= 0.5m)
                    {
                        change -= 0.5m;
                        counter++;
                    }
                    else if (change >= 0.2m)
                    {
                        change -= 0.2m;
                        counter++;
                    }
                    else if (change >= 0.1m)
                    {
                        change -= 0.1m;
                        counter++;
                    }
                    else if (change >= 0.05m)
                    {
                        change -= 0.05m;
                        counter++;
                    }
                else if (change >= 0.02m)
                    {
                        change -= 0.02m;
                        counter++;
                    }
                    else
                    {
                        change -= 0.01m;
                        counter++;
                    }
            }
            Console.WriteLine(counter);
           

        }
    }
}
