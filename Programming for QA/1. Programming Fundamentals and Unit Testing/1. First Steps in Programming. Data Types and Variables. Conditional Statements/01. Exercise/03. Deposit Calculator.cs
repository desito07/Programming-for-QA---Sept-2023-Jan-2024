namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double accumulatedInterest = depositedAmount * (annualInterestRate / 100);
            double interestPerMonth = accumulatedInterest / 12;
            double totalAmount = depositedAmount + termDeposit * interestPerMonth;
            Console.WriteLine(totalAmount);
        }
    }
}
