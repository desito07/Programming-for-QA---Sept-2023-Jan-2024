int[] array1 = Console.ReadLine()   
                .Split(" ")            
                .Select(int.Parse)   
                .ToArray();

int[] array2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

foreach(int arr in array1)
{
    foreach(int ar in array2)
    {
        if(arr == ar)
        {
            Console.Write(arr + " ");
        }
    }
}