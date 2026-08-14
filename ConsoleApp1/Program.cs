using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student("Lefa", "ST001", 75),
            new Student("Thabo", "ST002", 68),
            new Student("Kagiso", "ST003", 82),
            new Student("Neo", "ST004", 55),
            new Student("Tshepo", "ST005", 61)
        };

        StudentTasks tasks = new StudentTasks(students);

        Thread studentInfoThread =
            new Thread(tasks.DisplayStudentInformation);

        Thread averageThread =
            new Thread(tasks.CalculateAverageMark);

        Thread reportThread =
            new Thread(tasks.GenerateReport);

        Console.WriteLine("Student Information Thread Started...");
        Console.WriteLine("Calculating Average Thread Started...");
        Console.WriteLine("Report Thread Started...");
        Console.WriteLine();

        studentInfoThread.Start();
        averageThread.Start();
        reportThread.Start();

        studentInfoThread.Join();
        averageThread.Join();
        reportThread.Join();

        Console.WriteLine(tasks.StudentInformationResult);

        Console.WriteLine($"Average Mark: {tasks.AverageMark:F1}");
        Console.WriteLine();

        Console.WriteLine(tasks.ReportResult);

        Console.WriteLine("Report Generation Complete.");

        Console.ReadLine();
    }
}
