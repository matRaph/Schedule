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

        //0 - Date
        //1 - Alpha
        int sortedBy = 0;

        string mainStr = @"
This is your...
+-+-+-+-+-+-+-+-+
|S|C|H|E|D|U|L|E|
+-+-+-+-+-+-+-+-+

";
        public void Run_MainMenu()
        {
            switch (sortedBy)
            {
                case 0:
                    Schedule.Sort_Date();
                    break;
                case 1:
                    Schedule.Sort_Alpha();
                    break;
            }
            string prompt = mainStr + Schedule.List_Appoints();
            string[] options = { "Insert", "Remove", "Edit", "Sort", "Exit", "About" };
            Menu menu = new(prompt, options);

            int selectetIndex = menu.Run();

            switch (selectetIndex)
            {
                case 0:
                    Insert();
                    break;
                case 1:
                    Remove();
                    break;
                case 2:
                    Edit();
                    break;
                case 3:
                    Sort();
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
            ReturnFunc('M');
        }
        private void Insert()
        {
            WriteLine("\nInsert the content of your appointment below:\n");
            string content = ReadLine();
            WriteLine("\nInsert the date of your appointment below:");
            WriteLine("     --Use the format: dd/mm/yyyy. You can use any separator character (\"-\", \",\", \".\", \" \") instead of \"/\"\n");
            string date = ReadLine();

            schedule.Insert_Appoint(content, date);
            WriteLine("\nYour appointment was added successfully!");
            ReturnFunc('M');
        }
        private void Remove()
        {
            if (Schedule.Amount <= 0)
            {
                WriteLine("\nYou don't have appointments to remove");
                ReturnFunc('M');
            }

            int choosed = ChooseAppoint("remove:");

            if (choosed == -1)
            {
                Run_MainMenu();
            }
            schedule.Remove_Appoint(choosed);
            WriteLine("Your appointment was removed");
            ReturnFunc('R');
        }
        private void Edit()
        {
            if (Schedule.Amount <= 0)
            {
                WriteLine("\nYou don't have appointments to edit");
                ReturnFunc('M');
            }

            int choosed = ChooseAppoint("edit:");

            if (choosed == -1)
            {
                Run_MainMenu();
            }

            string prompt = mainStr + Schedule.Return_Appoint(choosed) + "\n";
            string[] options = { "Edit Content", "Edit Date", "Back"};
            Menu menu = new(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine("\nNew content:\n");
                    string new_cont = ReadLine();
                    Schedule.Edit_Content(choosed, new_cont);
                    WriteLine("\nYour appointment was updated!\n");
                    ReturnFunc('E');
                    break;
                case 1:
                    WriteLine("\nNew date:\n");
                    string new_date = ReadLine();
                    Schedule.Edit_Date(choosed, new_date);
                    WriteLine("\nYour appointment was updated!\n");
                    ReturnFunc('E');
                    break;
                case 2:
                    ReturnFunc('M');
                    break;
            }

            //WriteLine("\nInsert the index of the appointment you would like to edit:\n");
            //int ID = int.Parse(ReadLine());
            //WriteLine("\nInsert 1 to edit de content or 2 to edit the date of the appointment:\n");
            //int choose = int.Parse(ReadLine());

            //if (choose == 1)
            //{
            //    WriteLine("\nNew content:\n");
            //    string new_cont = ReadLine();
            //    Schedule.Edit_Content(ID, new_cont);
            //    WriteLine("\nYour appointment was updated!\n");
            //    ReturnFunc();
            //}
            //else
            //{
            //    WriteLine("\nNew date:\n");
            //    string new_date = ReadLine();
            //    Schedule.Edit_Date(ID, new_date);
            //    WriteLine("\nYour appointment was updated!\n");
            //    ReturnFunc();
            //}
        }
        private void Sort() { 
            string prompt = mainStr + Schedule.List_Appoints() + "\nSort by:";
            string[] options = { "Content", "Date", "Back" };

            Menu menuSort = new(prompt, options);
            int selectedIndex = menuSort.Run();

            if (selectedIndex == 0)
            {
                sortedBy = 1;
                WriteLine("\nYour schedule was sorted by alpha");
            }
            else if (selectedIndex == 1)
            {
                sortedBy = 0;
                WriteLine("\nYour schedule was sorted by date");
            }
            else if (selectedIndex == 2)
            {
                Run_MainMenu();
            }
            ReturnFunc('M');
        }

        private int ChooseAppoint(string funcName)
        {
            //Let user choose the appointment to make change or cancel the operation
            //Returns the index of the choosed appointment, if "Back" is selected, returns -1

            string prompt = mainStr + "Choose the appointment you'd like to " + funcName;

            List<string> appoints = Schedule.Appoints_Str();
            appoints.Add("Back");

            Menu menuSort = new(prompt, appoints.ToArray());
            int selectedIndex = menuSort.Run();

            if (appoints[selectedIndex] == "Back")
            {
                return -1;
            }
            return selectedIndex;
        }
        private bool AreYouSure()
        {
            return true;
        }
        private bool DoAgain()
        {
            return true;
        }
        private void ReturnFunc(char backScreen)
        {
            /*  M - Main menu
             *  R - Remove
             *  E - Edit
             * 
             * */
            WriteLine("\npress any key to return\n");
            ReadKey(true);

            switch (backScreen)
            {
                case 'M':
                    Run_MainMenu();
                    break;
                case 'R':
                    Remove();
                    break;
                case 'E':
                    Edit();
                    break;
            }
        }
    }
}
