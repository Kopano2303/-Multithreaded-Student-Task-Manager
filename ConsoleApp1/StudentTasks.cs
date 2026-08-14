using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentTasks
    {
        private List<Student> students;

        public string StudentInformationResult { get; private set; }
        public double AverageMark { get; private set; }
        public string ReportResult { get; private set; }

        public StudentTasks(List<Student> students)
        {
            this.students = students;
        }

        public void DisplayStudentInformation()
        {
            string result = "";

            foreach (Student student in students)
            {
                result += $"Student: {student.StudentName}\n";
                result += $"Student Number: {student.StudentNumber}\n";
                result += $"Mark: {student.Marks}\n\n";
            }

            StudentInformationResult = result;
        }
        public void CalculateAverageMark()
        {
            double total = 0;

            foreach (Student student in students)
            {
                total += student.Marks;
            }

            AverageMark = total / students.Count;
        }

        public void GenerateReport()
        {
            string result = "";

            foreach (Student student in students)
            {
                string status = student.Marks >= 50 ? "Pass" : "Fail";

                result += $"{student.StudentNumber} - {student.StudentName} - " +
                          $"{student.Marks} - {status}\n";
            }
            ReportResult = result;
        }

    }
}
