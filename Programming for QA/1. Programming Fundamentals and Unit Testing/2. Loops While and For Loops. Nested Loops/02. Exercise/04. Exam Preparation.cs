namespace _04;
class Program
{
    static void Main(string[] args)
    {
        int poorGrades = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();
        int counter = 0;
        string lastProblem = "";
        double totalGrades = 0.00;
        int poorGradeCounter = 0;

        while(command != "Enough")
        { 

            if(poorGrades == poorGradeCounter)
            {
                break;
            }
            double currentGrade = double.Parse(Console.ReadLine());
           
            if (currentGrade <= 4)
            {
                poorGradeCounter++;
            }
            totalGrades += currentGrade;
            counter++;
            lastProblem = command;
            command = Console.ReadLine();
        
        }
        if (poorGrades != poorGradeCounter)
        {

            double avrGrade = totalGrades / counter;

            Console.WriteLine($"Average score: {avrGrade:f2}");
            Console.WriteLine($"Number of problems: {counter}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
        else
        {
            Console.WriteLine($"You need a break, {poorGradeCounter} poor grades.");
        }
        
    }
}

