using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class Student
    {
        public string StudentName { get; set; }
        public double Average { get; set; } = 0.0;
        public bool AllAssignmentsCompleteTrueOrFalse { get; set; } = false;

        public Dictionary<string, Assignment> assignments = new Dictionary<string, Assignment>();

        public Student(string StudentName, double studentAverage, bool allAssignmentsComplete)
        {
            this.StudentName = StudentName;
            this.Average = studentAverage;
            this.AllAssignmentsCompleteTrueOrFalse = allAssignmentsComplete;
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
