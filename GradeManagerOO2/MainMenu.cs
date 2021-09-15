using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grade_Manager_OO
{
    public class MainMenu
    {
        public static void Main(string[] args)
        {
            Menu();

            static void Menu()
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "*********Grade Manager Ver 2.0*********"));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Keep track of your Classrooms,         "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Students and all grades                "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "1. Show ClassRooms.                    "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "2. Add a ClassRoom.                    "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "3. Remove a ClassRoom.                 "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "4. ClassRoom Details Menu.             "));
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "9. Exit App.                           "));

                Console.SetCursorPosition(21, 9);
                string classRoomChoice = Console.ReadLine();


                switch (classRoomChoice)
                {
                    case "1":
                        MainMenuLogic.ShowClassRooms();
                        {
                            break;
                        }

                    case "2":
                        MainMenuLogic.AddClassRoom();
                        {
                            break;
                        }

                    case "3":
                        MainMenuLogic.RemoveClassRoom();
                        {
                            break;
                        }

                    case "4":
                        ClassRoomDetailsMenu();
                        {
                            break;
                        }

                    case "9":
                        Exit();

                        {
                            break;
                        }
                }




                static void ClassRoomDetailsMenu()
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
                            ClassRoom.ShowStudents();
                            {
                                break;
                            }

                        case "2":
                            ClassRoom.AddStudent();
                            {
                                break;
                            }

                        case "3":
                            ClassRoom.RemoveStudent();
                            {
                                break;
                            }

                        case "4":
                            EditStudentDetailsMenu();
                            {
                                break;
                            }

                        case "5":
                            ClassRoom.ShowClassAverage();
                            {
                                break;
                            }

                        case "6":
                            ClassRoom.ShowTopStudent();
                            {
                                break;
                            }

                        case "7":
                            ClassRoom.ShowBottomStudent();
                            {
                                break;
                            }

                        case "8":
                            ClassRoom.Compare2Student();
                            {
                                break;
                            }
                        case "9":
                            ExitThisMenu();
                            {
                                break;
                            }
                    }

                }
                static void EditStudentDetailsMenu()
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
                            Student.ShowStudentSummary();
                            {
                                break;
                            }

                        case "2":
                            Student.AssignNewAssignment();
                            {
                                break;
                            }

                        case "3":
                            Student.ShowAssignments();
                            {
                                break;
                            }

                        case "4": /*GradeAssignments();*/
                            {
                                break;
                            }

                        case "5":
                            Student.ShowStudentBestGrade();
                            {
                                break;
                            }

                        case "6":
                            Student.ShowStudentWorstGrade();
                            {
                                break;
                            }


                        case "9":
                            ExitThisMenu();
                            {
                                break;
                            }
                    }


                }


                static void ExitThisMenu()
                {
                    Console.Clear();
                    Menu();
                }


                static void Exit()
                {
                    Console.Clear();
                    Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Exit? Press 9 again"));
                    Console.SetCursorPosition(20, 20);
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer != 9)
                    {
                        Menu();
                    }
                    Environment.Exit(9);
                }
            }
        }
    }
}
