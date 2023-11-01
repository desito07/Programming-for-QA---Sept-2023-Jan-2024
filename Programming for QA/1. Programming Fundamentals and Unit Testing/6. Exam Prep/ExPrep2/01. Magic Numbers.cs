
using System.Diagnostics.CodeAnalysis;

int num = int.Parse(Console.ReadLine());
bool isThereNoMatchingNumbers = true;


for (int i = 1; i <= num; i++)
{
    int current = i;
    int sum = 0;
    bool isAllDigitsPrime = true;

    while (current > 0)
    {
        int digit = current % 10;
        current = current / 10;
        bool isDigitPrime = digit == 2 || digit == 3 || digit == 5 || digit == 7;

        if (isDigitPrime)
        {
            sum += digit;
        }
        else
        {
            isAllDigitsPrime = false;
            break;
        }
    }
    if (isAllDigitsPrime && sum % 2 == 0)
    {
        Console.Write(i + " ");
        isThereNoMatchingNumbers = false;
    }
}
if (isThereNoMatchingNumbers)
{
        Console.WriteLine("no");
}


