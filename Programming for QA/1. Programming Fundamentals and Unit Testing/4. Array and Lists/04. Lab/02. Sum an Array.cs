int[] numbers = Console.ReadLine()   //"5 3 6 3 4"
                .Split(" ")          //["5", "3", "6", "3", "4"]   
                .Select(int.Parse)   //[5, 3, 6, 3, 4]    
                .ToArray();

int sum = 0;
for (int i = 0; i <= numbers.Length - 1 ; i++)
{
    int current = numbers[i];
    sum += current;
}
Console.WriteLine(sum);