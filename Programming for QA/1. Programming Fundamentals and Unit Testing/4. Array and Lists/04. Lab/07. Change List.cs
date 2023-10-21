
List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

//Console.WriteLine(string.Join(", ", numbers));

string command = Console.ReadLine();

while (command != "end")
{

    //валидна командa
    //1. command = "Delete 5".Split(" ") -> ["Delete", "5"]
    //2. command = "Insert 5 0".Split(" ") -> ["Insert", "5", "0"]

    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    //Console.WriteLine(commandName);

    int element = int.Parse(commandParts[1]);
    //Console.WriteLine(element);

    //delete all elements in the array, which are equal to the given element
    //{1, 2, 3, 4, 5, 5, 5, 6}
    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    //insert the element at the given position
    else if (commandName == "Insert")
    {

        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));
