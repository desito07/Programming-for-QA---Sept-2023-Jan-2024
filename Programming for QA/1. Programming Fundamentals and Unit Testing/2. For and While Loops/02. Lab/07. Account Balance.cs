using System.Transactions;

namespace _07._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0.0;

            while (command != "NoMoreMoney")
            {
                double currentDeposit = double.Parse(command);
               
                if (currentDeposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += currentDeposit;
                Console.WriteLine($"Increase: {currentDeposit:f2}");
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}