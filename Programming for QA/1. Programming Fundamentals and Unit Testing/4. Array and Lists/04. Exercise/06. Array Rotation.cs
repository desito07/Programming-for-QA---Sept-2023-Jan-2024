List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    int current = numbers[0];
    for(int j = 0; j < numbers.Count - 1; j++)
    {
        numbers[j] = numbers[j + 1];
    }
    numbers[numbers.Count - 1] = current;
}
Console.WriteLine(string.Join(" ", numbers));
