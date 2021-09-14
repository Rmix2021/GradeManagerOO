using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    class ClassRoom
    {
        public string name { get; set; }

        public ClassRoom(string classRoomName)
        {
            this.name = classRoomName;
        }

        public static void ShowStudents()
        {
            Console.WriteLine("Students");
        }

        public static void AddStudent()
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the Student in which you would like to add."));
            Console.SetCursorPosition(21, 9);
            string studentName = Console.ReadLine();
        }

        public static void RemoveStudent()
        {
            Console.WriteLine(" Remove Student");
        }

        public static void EditStudentDetailsMenu()
        {
            Console.WriteLine("EDit student menu");
        }

        public static void ShowClassAverage()
        {
            Console.WriteLine("Show average");
        }

        public static void ShowTopStudent()
        {
            Console.WriteLine("Show top student");
        }

        public static void ShowBottomStudent()
        {
            Console.WriteLine("Show bottom student");
        }

        public static void Compare2Student()
        {
            Console.WriteLine("Compare 2 Students");
        }



    }
}

