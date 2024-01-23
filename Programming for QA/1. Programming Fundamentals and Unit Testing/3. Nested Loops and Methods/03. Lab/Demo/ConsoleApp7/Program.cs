using System;

string type = Console.ReadLine();
if(type == "int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(GreaterThanTwoNumbers(num1, num2));
}
else if(type == "char")
{
    char char1 = char.Parse(Console.ReadLine());
    char char2 = char.Parse(Console.ReadLine());

    Console.WriteLine(GreaterThanTwoChars(char1, char2));
}
else if(type == "string")
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();

    Console.WriteLine(GreaterThanTwoStrings(str1, str2));
}

static string GreaterThanTwoStrings(string str1,string str2)
{
    if(str1.CompareTo(str2) > 0)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}

static char GreaterThanTwoChars(char char1, char char2)
{
    if(char1 > char2)
    {
        return char1;
    }
    else
    {
        return char2;
    }
}

static int GreaterThanTwoNumbers(int num1, int num2)
{
   if(num1 > num2)
    {
        return num1;
    }
   else
    {
        return num2;
    }
}