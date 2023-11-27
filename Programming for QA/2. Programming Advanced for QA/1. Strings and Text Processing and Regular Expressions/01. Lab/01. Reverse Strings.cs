
using System.Threading.Tasks.Dataflow;

string word = Console.ReadLine();

while (word != "end")
{

    char[] wordsAsCharArray = word.Reverse().ToArray();
    string reversed = string.Join("", wordsAsCharArray);
    Console.WriteLine($"{word} = {reversed}");
    word = Console.ReadLine();
}