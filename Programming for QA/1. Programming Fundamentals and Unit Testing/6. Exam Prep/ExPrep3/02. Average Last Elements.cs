
int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int n = int.Parse(Console.ReadLine());
double sum = 0.0;
for (int i = array.Length - 1; i > array.Length - 1 - n; i--)
{
    int current = array[i];
    sum += current;
   
}
double avr = sum / n;
Console.Write(avr);