//List<int> numbers = new List<int>();

/*numbers.Add(3);
numbers.Add(45);
numbers.Add(67);
numbers.Add(124);
numbers.Add(45);*/

//Console.WriteLine(numbers.Count);
//Console.WriteLine(numbers[numbers.Count - 1]);

//numbers.Remove(45);

//Console.WriteLine(numbers[1]);

//numbers.Insert(2, 56);
//Console.WriteLine(numbers.Count);
//Console.WriteLine(numbers[2]);

//Console.WriteLine(numbers);

//Contains - дали съществува в списъка

//Console.WriteLine(numbers.Contains(123));
//Console.WriteLine(numbers.Contains(124));

//int result = numbers[0] + numbers[3];
//Console.WriteLine(result);


// 1. отпечатвам с фор цикъл елементите от листа един по един по индекс
/*for(int index = 0; index <= numbers.Count - 1; index++)
{
    Console.Write(numbers[index] + " ");
}
Console.WriteLine();*/

//2. отпечатвам с фор ич цикъл пак елементите 
/*foreach(int number in numbers)
{
    Console.WriteLine(number);
}*/

//3. с джойн
//Console.WriteLine(string.Join(", ", numbers));

//използване на масив - при елементи, които няма да модифицинаме
//int[] numbersArray = { 3, 4, 5, 6 };

//използване на лист - при елементи, които ще модофицираме
//List<int> numbersList = new List<int>();

List<int> prices = new List<int>() { 3, 2 , 13, 9, 94 };
// 1. сортира елементите в списъка в нарастващ ред ascending order
prices.Sort(); // {2, 3, 9, 13, 94}

// 2.сортира елементите в списъка в намаляващ ред descending order
prices.Sort(); // {2, 3, 9, 13, 94} първо в нарастващ ред
prices.Reverse(); //{ 94, 13, 9, 3, 2} после в намаляващ


List<string> names = new List<string>() { "Ivan", "Georgi", "Pesho", "Misho"};
names.Sort(); //{  "Georgi", "Ivan", "Misho", "Pesho"}

