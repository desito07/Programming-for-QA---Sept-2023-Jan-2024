int n = int.Parse(Console.ReadLine());

while (true)
{
    n = int.Parse(Console.ReadLine());
    if (n >= 1 && n <= 100)
    {
        break;
    }
}
Console.WriteLine(n);