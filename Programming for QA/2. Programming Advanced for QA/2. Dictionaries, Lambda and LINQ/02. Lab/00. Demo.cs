using System.ComponentModel;

//Dictionary<string, string> phonebook = new();

//phonebook.Add("Desi Andreeva", "02380123456");
//phonebook.Add("Hey Ho Andreeva", "02392123478");
//phonebook.Add("Desi Andreeva", "02380123456");

//string value = phonebook["Desi Andreeva"];

//Console.WriteLine(value);

//phonebook["Desi Andreeva"] = "00000000000";

//Console.WriteLine(phonebook["Desi Andreeva"]);

//phonebook["Desi Andreeva"] = "123466789";

//Console.WriteLine(phonebook["Desi Andreeva"]);

//Console.WriteLine(phonebook.ContainsKey("HeyAndreeva"));

/*var fruits = new SortedDictionary<string, double>();
fruits["kiwi"] = 4.50;
fruits["orange"] = 2.50;
fruits["banana"] = 2.20;

foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Key} {fruit.Value}");
}

Dictionary<string, double> hello = new ()
{
    {"hey", 2.5 },
    {"ho", 5.2 },
    {"ha", 8.5 }
};*/

/*Dictionary<string, int> planes = new();

planes.Add("Airbus A320", 150);

if(planes.ContainsKey("Airbus A320"))
{
    Console.WriteLine("yes");
}*/

/*List<int> testList = new() { 1, 2, 2, 5, 6};
List<string> testListString = new() { "hello", "world", "Maybe?" };

Console.WriteLine(testList.Min());
Console.WriteLine(testListString.Min());

Console.WriteLine(testList.Max());
Console.WriteLine(testListString.Max());

Console.WriteLine(testList.Sum());
Console.WriteLine(testList.Average());*/


List<string> testListString = new() { "hello", "world", "Maybe?" };

List<string> names = new() { "Desi", "Teq", "Koko" };

var result = names.Select(x => x + "!");
Console.WriteLine(string.Join(", ", result));



