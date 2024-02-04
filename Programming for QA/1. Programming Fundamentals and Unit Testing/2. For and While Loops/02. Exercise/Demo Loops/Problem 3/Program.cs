int n = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;

for (int i = 0; i < n; i++)
{
    int current = int.Parse(Console.ReadLine());
    if (maxNum < current)
    {
        maxNum = current;

    }
}
Console.WriteLine(maxNum);