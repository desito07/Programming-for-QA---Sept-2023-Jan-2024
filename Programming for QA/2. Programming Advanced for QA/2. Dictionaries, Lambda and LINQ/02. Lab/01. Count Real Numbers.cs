
int[] input = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

SortedDictionary<int, int> numbersFrequancy = new();

foreach (int inputItem in input)
{
    if (numbersFrequancy.ContainsKey(inputItem))
    {
        numbersFrequancy[inputItem] = numbersFrequancy[inputItem] + 1;
    }
    else
    {
        numbersFrequancy.Add(inputItem, 1);
    }
}

foreach (KeyValuePair<int, int> pair in numbersFrequancy)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}


