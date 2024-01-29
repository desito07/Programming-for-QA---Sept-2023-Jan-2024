int n = int.Parse(Console.ReadLine());
int sum = 0;
int current = 0;

for (int i = 1; i <= n; i++)
{
    current = i;
    if(current == 1)
    {
        Console.Write(current);
    }
    else
    {
        Console.Write("+" + current);
    }
    sum += i;
    
}
Console.WriteLine("=" + sum);