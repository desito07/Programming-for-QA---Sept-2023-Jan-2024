string text = Console.ReadLine();

int result = VowelsCountMethod(text);

Console.WriteLine(result);

static int VowelsCountMethod(string text)
{
    int count = 0;
    
    for(int i = 0; i <= text.Length - 1; i++)
    {
    char s = text[i];
        if (s == 'o' || s == 'O' 
            || s == 'i' || s == 'I' 
            || s == 'a' || s == 'A' 
            || s == 'e' || s == 'E' 
            || s == 'u' || s == 'U')
        {
            count++;
        }
    }
    return count;  
}

