static void PrintLinе(int start, int end)
{
    for(int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int num)
{
    for(int j = 1; j<= num; j++)
    {
        PrintLinе(1, j);
    }
    for(int j = num - 1; j >= 1; j--)
    {
        PrintLinе(1, j);
    }
    
}

int number = int.Parse(Console.ReadLine());
PrintTriangle(number);
