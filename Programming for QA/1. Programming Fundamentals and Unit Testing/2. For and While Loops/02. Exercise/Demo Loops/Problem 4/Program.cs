using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());
int value = 0;
int sum = 0;

for (int i = 0; i < n; i++)
{
    char ch = char.Parse(Console.ReadLine());
    if(ch == 'a')
    {
        value = 1;
    }
    else if(ch == 'e')
    {
        value = 2;
    }
    else if (ch == 'i')
    {
        value = 3;
    }
    else if (ch == 'o')
    {
        value = 4;
    }
    else if (ch == 'u')
    {
        value = 5;
    }
    sum += value;
}
Console.WriteLine(sum);