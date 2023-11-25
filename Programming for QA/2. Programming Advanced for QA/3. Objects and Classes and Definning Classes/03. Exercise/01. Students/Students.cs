using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Students
{
    internal class Student
    {
        private string fname;
        private string lname;
        private double grade;

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string fname, string lname, double grade)
        {
            FirstName = fname;
            LastName = lname;
            Grade = grade;
        }
    }
}
