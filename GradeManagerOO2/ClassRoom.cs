using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    public class ClassRoom
    {
        public string name { get; set; } = "Default class room";

        public Dictionary<string, Student> Student = new Dictionary<string, Student>();

        public ClassRoom(string classRoomName)
        {
            this.name = classRoomName;
        }

        public void ClassRoomDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "*********Edit Classrooms Menu**********"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Currently Editing 'classroom xyz'      "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. Show Students.                      "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. Add Student.                        "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Remove Student.                     "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. Student Details Menu.               "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "5. Show class average.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "6. Show top student.                   "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "7. Show worst student.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "8. Compare 2 students.                 "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit this menu.                     "));
            Console.SetCursorPosition(21, 12);

            string classRoomChoice = Console.ReadLine();

            switch (classRoomChoice)
            {
                case "1":
                    ShowStudents();
                    {
                        break;
                    }

                case "2":
                    AddStudent();
                    {
                        break;
                    }

                case "3":
                    RemoveStudent();
                    {
                        break;
                    }

                case "4":
                    //Student[StudentName].EditStudentDetailsMenu();
                    {
                        break;
                    }

                case "5":
                    ShowClassAverage();
                    {
                        break;
                    }

                case "6":
                    ShowTopStudent();
                    {
                        break;
                    }

                case "7":
                    ShowBottomStudent();
                    {
                        break;
                    }

                case "8":
                    Compare2Student();
                    {
                        break;
                    }
                case "9":
                    ExitThisMenu();
                    {
                        break;
                    }
            }

            void ShowStudents()
            {
                Console.WriteLine("Students");
            }

            void AddStudent()
            {
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the Student in which you would like to add."));
                Console.SetCursorPosition(21, 9);
                string studentName = Console.ReadLine();


            }

            void RemoveStudent()
            {
                Console.WriteLine(" Remove Student");
            }           

            void ShowClassAverage()
            {
                Console.WriteLine("Show average");
            }

            void ShowTopStudent()
            {
                Console.WriteLine("Show top student");
            }

            void ShowBottomStudent()
            {
                Console.WriteLine("Show bottom student");
            }

            void Compare2Student()
            {
                Console.WriteLine("Compare 2 Students");
            }

            void ExitThisMenu()
            {
                Console.Clear();
                MainMenu.Menu();
            }

        }
    }
}

