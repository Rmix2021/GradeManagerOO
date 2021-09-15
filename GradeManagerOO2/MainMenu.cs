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
        }

        public Dictionary<string, ClassRoom> ClassRooms = new Dictionary<string, ClassRoom>();
        public static void Menu()
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
                    ShowClassRooms();
                    {
                        break;
                    }

                case "2":
                    AddClassRoom();
                    {
                        break;
                    }

                case "3":
                    RemoveClassRoom();
                    {
                        break;
                    }

                case "4":
                    //ClassRoom.ClassRoomDetailsMenu();
                    {
                        break;
                    }

                case "9":
                    Exit();

                    {
                        break;
                    }
            }
        }

        static void ShowClassRooms()
        {
            Console.WriteLine("Show classrooms");
        }

        static void AddClassRoom()
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Name the classroom in which you would like to add."));
            Console.SetCursorPosition(21, 9);
            string classRoomName = Console.ReadLine();

        }

        static void RemoveClassRoom()
        {
            Console.WriteLine("Remove Classroom");
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
        
    

