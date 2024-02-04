int n = int.Parse(Console.ReadLine());

while (true)
{
    int digit = n / 10;
    if(n % digit == 0)
    {
        Console.WriteLine($"{n} is special");
        break;
    }
    else
    {
        Console.WriteLine($"{n} is not special");
        break;
    }
}
