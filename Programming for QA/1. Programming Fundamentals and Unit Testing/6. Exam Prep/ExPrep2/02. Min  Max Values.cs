int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int n = int.Parse(Console.ReadLine());
int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int current = array[i];
    if(current > max)
    {
        max = current;
    }
    if(current < min)
    {
        min = current;
    }
}
Console.WriteLine(max);
Console.WriteLine(min);

