int[] numbers = Console.ReadLine()   //"5 3 6 3 4"
                .Split(" ")          //["5", "3", "6", "3", "4"]   
                .Select(int.Parse)   //[5, 3, 6, 3, 4]    
                .ToArray();

int evenSum = 0;
int oddSum = 0;

for (int i = 0; i <= numbers.Length - 1; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenSum += numbers[i];
    }
    else
    {
        oddSum += numbers[i];
    }
}
int diff = evenSum - oddSum;
Console.WriteLine(diff); 