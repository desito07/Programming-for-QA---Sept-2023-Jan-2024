static int VowelsCount(string textMe)
{
    int count = 0;

    for(int i = 0; i <= textMe.Length - 1; i++)
    {
        if (textMe[i] == 'a'
            || textMe[i] == 'A'
            || textMe[i] == 'E' 
            || textMe[i] == 'O' 
            || textMe[i] == 'I' 
            || textMe[i] == 'U' 
            || textMe[i] == 'a' 
            || textMe[i] == 'e' 
            || textMe[i] == 'o' 
            || textMe[i] == 'i'
            || textMe[i] == 'u')
        {
            count++;
        }
       
    }
    return count;
}


string text = Console.ReadLine();

Console.WriteLine(VowelsCount(text));

