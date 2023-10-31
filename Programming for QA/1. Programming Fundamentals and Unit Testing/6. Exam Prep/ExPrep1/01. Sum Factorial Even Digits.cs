

// Read a number from the console and analyse digits
// Calculate Factorial using a method
// Divide the number by % 10 and / 10
// if even check 

//int result = CalculateFactorial(4);
//Console.WriteLine(result);

int result = int.Parse(Console.ReadLine());
int sum = 0;

while (result != 0)
{
    int digit = result % 10;

    if(digit % 2 == 0)
    {
        int resultFactorial = CalculateFactorial(digit);
        sum += resultFactorial;
    }
    //Console.WriteLine(digit);
    result = result / 10;
}

Console.WriteLine(sum);
static int CalculateFactorial(int num)
{
    int result = 1;

    while (num > 0)
    {
        result = result * num;
        num -= 1;
    }

    return result;
}


