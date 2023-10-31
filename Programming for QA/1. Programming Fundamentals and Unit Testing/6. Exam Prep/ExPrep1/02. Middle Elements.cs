// Read an array of integers

int [] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

//Find the middle numbers
for (int i = 0; i <= array.Length - 1; i++)
{
    int current = array[i];
}

int middleRightElementIndex = array.Length / 2;
int middleLeftElementIndex = middleRightElementIndex - 1;
double avr = (array[middleRightElementIndex] + array[middleLeftElementIndex]) / 2.0;
Console.WriteLine($"{avr:f2}");

//Console.WriteLine(array[middleRightElementIndex]);
//Console.WriteLine(middleLeftElementIndex);







