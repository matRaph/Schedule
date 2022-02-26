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
        public void Run_MainMenu()
        {
            Schedule appoints = new Schedule();
            string prompt = @"
This is your...
+-+-+-+-+-+-+-+-+
|S|C|H|E|D|U|L|E|
+-+-+-+-+-+-+-+-+
";

            string[] options = { "Insert", "Remove", "Edit", "Sort", "Exit", "About" };
            Menu menu = new Menu(prompt, options);
            int selectetIndex = menu.Run();

            switch (selectetIndex)
            {
                case 0:

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
            WriteLine("Press any key to return to main menu\n");
            ReadKey(true);
            Run_MainMenu();
        }
    }
}
