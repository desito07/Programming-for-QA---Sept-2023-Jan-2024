int[] array = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int last = array[array.Length - 1];

    for (int j = array.Length - 1; j > 0; j--)
    {
        array[j] = array[j - 1];
    }
    array[0] = last;
}

Console.WriteLine(string.Join(", ", array));
