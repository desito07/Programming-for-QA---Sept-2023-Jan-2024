int n = int.Parse(Console.ReadLine());
bool isHappy = true;

for (int i = 1; i <= 9; i++)
{
    for (int j = 0; j <= 9; j++)
    {
        for (int k = 0; k <=9; k++)
        {
            for (int d = 0; d <= 9; d++)
            {
                if (i+j==n && k+d == n)
                {
                    Console.Write($"{i}{j}{k}{d} ");

                }
            }
        }
    }
}
Console.WriteLine();
