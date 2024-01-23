
string text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

static string RepeatString(string text, int count)
{
    string output = "";
    for (int i = 0; i < count; i++)
    {
        output += text;
    }
    return output;
}
string result = RepeatString(text, count);
Console.WriteLine(result);