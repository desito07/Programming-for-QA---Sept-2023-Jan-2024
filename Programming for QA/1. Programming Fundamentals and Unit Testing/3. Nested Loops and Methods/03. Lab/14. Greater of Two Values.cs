
using System.Reflection.Metadata.Ecma335;

static int FindGreaterNum(int num1, int num2)
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

static char FindGreaterChar(char c1, char c2)
{
    if (c1 > c2)
    {
        return c1;
    }
    else
    {
        return c2;
    }
}

static string FindGreaterString(string s1, string s2)
{
    if(s1.CompareTo(s2) > 0)
    {
        return s1;
    }
    else
    {
        return s2;
    }
}


string valueType = Console.ReadLine();

if (valueType == "int")
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterNum(num1, num2));

}
else if(valueType == "char")
{
    char ch1 = char.Parse(Console.ReadLine());
    char ch2 =  char.Parse(Console.ReadLine());

    Console.WriteLine(FindGreaterChar(ch1, ch2));
}
else if(valueType == "string")
{
    string txt1 = Console.ReadLine();
    string txt2 = Console.ReadLine();

    Console.WriteLine(FindGreaterString(txt1, txt2));
}

