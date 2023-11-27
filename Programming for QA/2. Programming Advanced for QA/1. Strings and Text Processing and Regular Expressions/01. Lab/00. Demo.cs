using System.Diagnostics;
using System.Text;

string text = "Hello World";
text = text + " Updated!";

//Console.WriteLine(text);

char ch = text[2];
//Console.WriteLine(ch);

string str = "str";
char[] charArr = str.ToCharArray();
//Console.WriteLine(str.ToCharArray());

string firstWord = "Hey";
string secondWord = "World";

//Console.WriteLine(firstWord + " " + secondWord);
//Console.WriteLine(string.Concat(firstWord, secondWord));

string wordA = "Hey";
string wordB = "Ho";
string wordC = "Hola!";

//Console.WriteLine(string.Join("", wordA, wordB, wordC));

/*string s = "ABC";
string[] arr = new string[3];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = s;
}
string repeated = string.Join("|", arr);
Console.WriteLine(repeated);*/

/*string alphabet = "dsfhsghalfdgfg";
Console.WriteLine(alphabet.Substring(3, 3));

string text1 = "d;ajghjsdfh'ashs;'hjkss fdh;j;shj hfd;jkd;fjdf ;  fdl;jshj;f";
string[] words1 = text1.Split(new char[] { ' ', '@'  });
Console.WriteLine(string.Join("| ", words1));*/

/*StringBuilder output = new StringBuilder();

output.Append("Hello");
output.Append("World?");

Console.WriteLine(output.ToString());*/


Stopwatch sw = new Stopwatch();
sw.Start();

string text2 = "";

for(int i = 0; i < 20000; i++)
{
    text2 += i;
}

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

//**********************

Stopwatch sb = new Stopwatch();
sb.Start();
StringBuilder text3 = new StringBuilder();
for(int i = 0; i < 20000; i++)
{
    text3.Append(i);
}

sb.Stop();
Console.WriteLine(sb.ElapsedMilliseconds);