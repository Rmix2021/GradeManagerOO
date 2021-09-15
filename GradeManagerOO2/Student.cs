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

        public Student(string StudentNamed)
        {
            this.StudentName = StudentNamed;        
        }

        public Dictionary<string, Assignment> assignmentsDictionary = new Dictionary<string, Assignment>();


        public void EditStudentDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "******Edit Student Details Menu********"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Currently Editing 'Student xyz'        "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. Show Student Summary.               "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. Assign Student New Assignment.      "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Show Assignments.                   "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. Grade Assignments.                  "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "5. Show students Best Grade.           "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "6. Show students worst Grade.          "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit this menu.                     "));
            Console.SetCursorPosition(21, 10);

            string StudentDetailsChoice = Console.ReadLine();
            switch (StudentDetailsChoice)
            {
                case "1":
                    ShowStudentSummary();
                    {
                        break;
                    }

                case "2":
                    AssignNewAssignment();
                    {
                        break;
                    }

                case "3":
                    ShowAssignments();
                    {
                        break;
                    }

                case "4": /*GradeAssignments();*/
                    {
                        break;
                    }

                case "5":
                    ShowStudentBestGrade();
                    {
                        break;
                    }

                case "6":
                    ShowStudentWorstGrade();
                    {
                        break;
                    }


                case "9":
                    ExitThisMenu();
                    {
                        break;
                    }
            }

            void ExitThisMenu()
            {
                Console.Clear();
                MainMenu.Menu();
            }
        }


        void ShowStudentSummary()
        {
            Console.WriteLine("Show Student details");
        }


        void AssignNewAssignment()
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the assignment in which yo would like to add."));
            Console.SetCursorPosition(21, 9);
            //string assignmentName = Console.ReadLine();

            string assignmentName = Console.ReadLine();
            assignmentsDictionary.Add(assignmentName, new Assignment(assignmentName));
        }

        void ShowAssignments()
        {
            Console.WriteLine("Show assignments");
        }


        void ShowStudentBestGrade()
        {
            Console.WriteLine("Show student best grade");
        }


        void ShowStudentWorstGrade()
        {
            Console.WriteLine("Show worst grade");
        }

    }
}
