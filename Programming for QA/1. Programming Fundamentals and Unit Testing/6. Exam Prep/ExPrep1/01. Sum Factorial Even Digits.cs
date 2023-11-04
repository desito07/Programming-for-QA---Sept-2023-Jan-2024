

// Read a number from the console and analyse digits
// Calculate Factorial using a method
// Divide the number by % 10 and / 10
// if even check 

//int result = CalculateFactorial(4);
//Console.WriteLine(result);

int n = int.Parse(Console.ReadLine());
int sum = 0;


while (n != 0)
{
    int digit = n % 10;

    if (digit % 2 == 0)
    {
        int factorial = CalculateFactorial(digit);
        sum += factorial;
    }
    //Console.WriteLine(digit);
    n = n / 10;
}
Console.WriteLine(sum);

static int CalculateFactorial(int num)
{
    int factor = 1;
    while (num > 0)
    {
        factor = factor * num;
        num -= 1;
    }
    return factor;
}


