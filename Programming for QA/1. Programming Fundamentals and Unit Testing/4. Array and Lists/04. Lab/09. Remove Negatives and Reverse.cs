List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

//Console.WriteLine(string.Join(", ", numbers));

List<int> numbers1 = new List<int>();
foreach (var number in numbers)
{
    if (number > 0)
    {
        numbers1.Add(number);
    }
}
//Console.WriteLine(string.Join(" ", numbers1));

// Desi solution
/*numbers.RemoveAll(number => number < 0);
numbers.Reverse();*/

if (numbers1.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    numbers1.Reverse();
    Console.WriteLine(string.Join(" ", numbers1));
}

