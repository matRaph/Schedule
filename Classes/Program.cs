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
            menu.Run_MainMenu();
        }
    }
}
