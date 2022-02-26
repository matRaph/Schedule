using System;
using System.Globalization;
namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController menu = new MenuController();
            Schedule schedule = new Schedule();
            schedule.Insert_Appoint("amsldnasd", "13,03,2020");
            menu.Run_MainMenu();
        }
    }
}
