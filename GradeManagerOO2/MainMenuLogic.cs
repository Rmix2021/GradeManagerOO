using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Manager_OO
{
    class MainMenuLogic
    {
        public static void ShowClassRooms()
        {
            Console.WriteLine("Show classrooms");
        }

        public static void AddClassRoom()
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the class room in which yo would like to add."));
            Console.SetCursorPosition(21, 9);
            string classroomName = Console.ReadLine();
        }

        public static void RemoveClassRoom()
        {
            Console.WriteLine("Remove Classroom");
        }


    }
}
