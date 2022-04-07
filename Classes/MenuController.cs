using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Schedule
{
    class MenuController
    {
        Schedule schedule = new();

        public void Run_MainMenu()
        {
            //Schedule appoints = new Schedule();
            string prompt = @"
This is your...
+-+-+-+-+-+-+-+-+
|S|C|H|E|D|U|L|E|
+-+-+-+-+-+-+-+-+

";
            prompt += Schedule.List_Appoints();

            string[] options = { "Insert", "Remove", "Edit", "Sort", "Exit", "About" };
            Menu menu = new Menu(prompt, options);
            int selectetIndex = menu.Run();

            switch (selectetIndex)
            {
                case 0:
                    Insert();
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:
                    ExitProgram();
                    break;
                case 5:
                    DisplayAbout();
                    break;
            }
        }
        

        private void ExitProgram()
        {
            WriteLine("Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void DisplayAbout()
        {
            WriteLine("\nThis is a simple schedule manager made by Raphael Matias.");
            WriteLine("You can find me at about.me/raph.m");
            WriteLine("Hope you enjoy it :)");
            WriteLine("Press any key to return to your schedule\n");
            ReadKey(true);
            Run_MainMenu();
        }
        private void Insert()
        {
            WriteLine("\nInsert the content of your appointment below:\n");
            string content = ReadLine();
            WriteLine("\nInsert the date of your appointment below:");
            WriteLine("     --Use the format: mm/dd/yyyy. You can use any separator character (\"-\", \",\", \".\", \" \") instead of \"/\"\n");
            string date = ReadLine();

            schedule.Insert_Appoint(content, date);
            WriteLine("\nYour appointment was added successfully!");
            WriteLine("Press any key to return to your schedule\n");
            ReadKey(true);
            Run_MainMenu();
        }
    }
}
