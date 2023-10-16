
using System.Runtime.ExceptionServices;

int n = int.Parse(Console.ReadLine());

for (int firstPart = 2; firstPart <= n; firstPart+= 2)
{
    for (int secondPart = 1;  secondPart <= n; secondPart+= 2)
    {
        int result = firstPart * secondPart;
        Console.Write($"{firstPart}{secondPart}{result} ");
    }
}
