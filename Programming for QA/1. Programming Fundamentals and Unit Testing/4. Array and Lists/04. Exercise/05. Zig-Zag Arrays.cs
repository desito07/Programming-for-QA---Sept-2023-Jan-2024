
int n = int.Parse(Console.ReadLine());
List<int> numbers1 = new List<int>();
List<int> numbers2 = new List<int>();

for(int i = 0; i < n; i++)
{
    List<int> current = Console.ReadLine()
                         .Split()
                         .Select(int.Parse)
                         .ToList();
    int num1 = current[0];
    int num2 = current[1];

    if(i % 2 == 0)
    {
        numbers1.Add(num1);
        numbers2.Add(num2);
    }
    else
    {
        numbers1.Add(num2);
        numbers2.Add(num1);
    }
}

Console.WriteLine(string.Join(" ", numbers1));
Console.WriteLine(string.Join(" ", numbers2));
