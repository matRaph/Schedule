using System;
using System.Globalization;
namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController menu = new MenuController();
            Schedule schedule = new();
            schedule.Insert_Appoint("akjsdnaskjdfn", "5 5 2003");
            menu.Run_MainMenu();
        }
    }
}
