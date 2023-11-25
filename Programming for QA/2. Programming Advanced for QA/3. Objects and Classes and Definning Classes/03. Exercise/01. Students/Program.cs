using _01._Students;
using System.Collections.Generic;

int num = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();

for (int i = 1; i <= num; i++)
{
    string current = Console.ReadLine();
    string[] currentParts = current.Split(" ");

    string fname = currentParts[0];
    string lname = currentParts[1];
    double grade = double.Parse(currentParts[2]);

    Student student = new Student(fname, lname, grade);
    students.Add(student);
    
}

students = students.OrderByDescending(x => x.Grade).ToList();

foreach(Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}


