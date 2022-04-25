using System;
using System.Globalization;

namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Schedule";

            MenuController menu = new MenuController();
            Schedule schedule = new();
            schedule.Insert_Appoint("akjsdnaskjdfn", "5 5 2003");
            schedule.Insert_Appoint("aajsdnaskjdfn", "5 5 2004");

            menu.Run_MainMenu();
            
        }
    }
}
