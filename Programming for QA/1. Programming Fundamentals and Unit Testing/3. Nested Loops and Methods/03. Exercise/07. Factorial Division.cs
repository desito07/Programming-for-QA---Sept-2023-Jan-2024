int num1 = int.Parse(Console.ReadLine());
int num2  = int.Parse(Console.ReadLine());

int factFirstNum = CalculateFactorial(num1);
int factSecondNum = CalculateFactorial(num2);

Console.WriteLine(factFirstNum / factSecondNum);


static int CalculateFactorial(int number)
{
    int factoriel = 1;
    for (int i = 1; i <= number; i++)
    {
        factoriel = factoriel * i;
    }  
    return factoriel;
}