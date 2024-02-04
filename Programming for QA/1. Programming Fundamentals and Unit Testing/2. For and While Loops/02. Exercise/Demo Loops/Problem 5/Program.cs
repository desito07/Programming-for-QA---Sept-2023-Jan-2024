int n = int.Parse(Console.ReadLine());
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;

for (int i = 0; i < n; i++)
{
    int current = int.Parse((Console.ReadLine()));
    if (current % 2 == 0)
    {
        sum2++;
    }
    if (current % 3 == 0)
    {
        sum3 ++;
    }
    if(current % 4 == 0){
        sum4 ++;
    }
}

double perc2 = sum2 * 1.0 / n * 100;
double perc3 = sum3 * 1.0 / n * 100;
double perc4 = sum4 * 1.0 / n * 100;

Console.WriteLine($"{perc2:f2}%");
Console.WriteLine($"{perc3:f2}%");
Console.WriteLine($"{perc4:f2}%");