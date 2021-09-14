using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class Student
    {
        public string name { get; set; }
        public double average { get; set; }
        public bool completionStatus { get; set; }

        

        public Student(string studentName, double studentAverage, bool studentCompletionStatus)
        {
            this.name = studentName;
            this.average = studentAverage;
            this.completionStatus = studentCompletionStatus;
        }

        public static void ShowStudentSummary()
        {
            Console.WriteLine("Show Student details");
        }

        public static void AssignNewAssignment()
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the assignment in which yo would like to add."));
            Console.SetCursorPosition(21, 9);
            string assignmentName = Console.ReadLine();

        }

        public static void ShowAssignments()
        {
            Console.WriteLine("Show assignments");
        }

        public static void ShowStudentBestGrade()
        {
            Console.WriteLine("Show student best grade");
        }

        public static void ShowStudentWorstGrade()
        {
            Console.WriteLine("Show worst grade");
        }

    }
}
