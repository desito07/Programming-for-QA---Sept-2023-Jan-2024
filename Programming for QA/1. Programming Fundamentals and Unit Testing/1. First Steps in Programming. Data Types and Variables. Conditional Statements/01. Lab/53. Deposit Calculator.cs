using System.Transactions;

double depositedAmount = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double calculatedInterest = depositedAmount * (annualInterestRate / 100);
double interestForMonth = calculatedInterest / 12;
double totalAmount = depositedAmount + depositTerm * interestForMonth;

Console.WriteLine($"{totalAmount:f2}");