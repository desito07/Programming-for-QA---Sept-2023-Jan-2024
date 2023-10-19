//Demo Lab

//==========================================
//int[] numbers = { 12, 22, 34, 56, 67 };//

/*Console.WriteLine(numbers.Length);
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[numbers.Length - 1]);*/

//==========================================
/*int[] prices = new int[10];

prices[0] = 5;
prices[1] = 34;
prices[2] = 56;
prices[3] = 98;

for (int i = 0; i <= prices.Length - 1; i++)
{
    Console.WriteLine(prices[i]);
}

prices[0] = 23;

Console.WriteLine(prices[10]);*/

//========================================
/*int[] num = new int[7];

for (int i = 0; i <= num.Length - 1; i++)
{
    num[i] = int.Parse(Console.ReadLine());

}*/

//========================================
/*string text = "dog, cat, frog, rabbit, turtle";

string[] animals = text.Split(", ");
Console.WriteLine(string.Join(" ", animals));*/

//=========================================
double[] grades = {3.40, 4.50, 5.60, 6.00 };

    foreach (double grade in grades)
{
    Console.WriteLine(grade);
}

