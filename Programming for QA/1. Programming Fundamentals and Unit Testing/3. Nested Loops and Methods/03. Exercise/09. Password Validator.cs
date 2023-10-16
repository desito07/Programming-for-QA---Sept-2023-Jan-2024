string password = Console.ReadLine();

bool isValidLength = password.Length >= 6 && password.Length <= 10;
bool isValidContent = CheckContent(password);
bool isValidCountDigit = CheckCount(password);
if (isValidLength == true && isValidContent == true && isValidCountDigit == true)
{
    Console.WriteLine("Password is valid");
}
else
{
    if (isValidLength == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (isValidContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    if (isValidCountDigit == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}

static bool CheckContent(string password)
{
    for (int i = 0; i <= password.Length - 1; i++)
    {
        char symbol = password[i];
        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    }
    return true;
}

static bool CheckCount(string password)
{
    int count = 0;
    for (int i = 0; i <= password.Length - 1; i++)
    {
        char symbol = password[i];
        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }
    return count >= 2;
}
