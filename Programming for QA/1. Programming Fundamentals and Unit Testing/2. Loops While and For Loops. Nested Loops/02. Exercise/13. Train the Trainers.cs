using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;

namespace _13._Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJuryMembers = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double totalGrade = 0.0;
            int counter = 0;

            while (command != "Finish")
            {
                double avgGrade = 0.0;
                counter++;

                for (int i = 1; i <= numJuryMembers; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    totalGrade += currentGrade;
                    avgGrade += currentGrade;
                }
                
             Console.WriteLine($"{command} - {avgGrade/numJuryMembers:f2}");
             command = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {totalGrade / (counter * numJuryMembers):f2}.");
        }
    }
}
