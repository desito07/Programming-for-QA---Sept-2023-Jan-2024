static int CalRectArea(int w, int l)
{
    return w * l;
}

int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int area = CalRectArea(width, lenght);
Console .WriteLine(area);