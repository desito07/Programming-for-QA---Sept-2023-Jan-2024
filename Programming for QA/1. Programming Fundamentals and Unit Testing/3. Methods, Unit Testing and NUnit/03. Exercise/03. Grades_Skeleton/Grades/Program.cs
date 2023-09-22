namespace Grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine(GradeProcessor.DefineGrade(grade));
        }
    }
}