static string StringMe(string text, int count)
{
    string output = "";
    for (int i = 0;  i < count; i++)
    {
        output += text;
    }
    return output;
}

string textio = Console.ReadLine();
int num = int.Parse(Console.ReadLine());
string result = StringMe(textio, num);

Console.WriteLine(result);
