namespace _12._Sum_of_Prime_and_Non_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = (Console.ReadLine());
            int sumPrimeNum = 0;
            int sumNonprimeNum = 0;

            while (command != "stop")
            {
                int currentNum = int.Parse(command);
                if (currentNum < 0)
                {

                    command = (Console.ReadLine());
                    Console.WriteLine("Number is negative");
                    continue;
                }

                int divisors = 0;
                for (int i = 1; i <= currentNum; i++)
                {
                    if (currentNum % i == 0)
                    {
                        divisors++;
                    }
                }
                if (divisors == 2)
                {
                    sumPrimeNum += currentNum;
                }
                else
                {
                    sumNonprimeNum += currentNum;
                }
                command = (Console.ReadLine());
            }
            Console.WriteLine($"Sum of all prime numbers is: + {sumPrimeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonprimeNum}");
        }
    }
}