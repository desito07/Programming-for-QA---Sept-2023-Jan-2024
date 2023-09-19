namespace _10._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            int classNumber = 1;
            double totalGrades = 0.00;
            int expelledCounter = 0;

            while (classNumber <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrades += grade;

                
                if(grade < 4.00)
                {
                   expelledCounter++;
                }
                if(expelledCounter > 1)
                {
                    Console.WriteLine($"{nameOfStudent} has been excluded at {classNumber - 1} grade");
                    break;
                }

                classNumber++;

            }
            double averageGrade = totalGrades / 12;
            if (expelledCounter <= 1)
            {
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}