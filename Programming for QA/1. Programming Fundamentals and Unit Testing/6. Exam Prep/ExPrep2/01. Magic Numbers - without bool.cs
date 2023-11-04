using System.Diagnostics.CodeAnalysis;

int num = int.Parse(Console.ReadLine());
int totalCountOfMagicNumbers = 0;


for (int i = 1; i <= num; i++)
{
    int current = i;
    int sum = 0;
    int totalNumberOfDigits = 0;
    int totalNumberOfPrimeDigits = 0;

    while (current > 0)
    {
        int digit = current % 10;
        current = current / 10;
        totalNumberOfDigits++;
        
        if (digit == 2 || digit == 3 || digit == 5 || digit == 7)
        {
            sum += digit;
            totalNumberOfPrimeDigits++;
        }
      
    }
    if (totalNumberOfDigits == totalNumberOfPrimeDigits && sum % 2 == 0)
    {
        Console.Write(i + " ");
        totalCountOfMagicNumbers++;
    }
}
if (totalCountOfMagicNumbers == 0)
{
    Console.WriteLine("no");
}


