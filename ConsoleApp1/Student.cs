using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentNumber { get; set; }
        public double Marks { get; set; }

        public Student(string studentName, string studentNumber, double marks)
        {
            StudentName = studentName;
            StudentNumber = studentNumber;
            Marks = marks;
        }
    }
}
