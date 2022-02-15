using System;
using System.Globalization;
namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.Insert_Appoint("Do something", "15, 5, 2020");
            schedule.Insert_Appoint("Walk my cat", "15, 5, 2020");
            schedule.List();
            schedule.Edit_Date(1, "15,2,2022");
            schedule.List();
            schedule.Remove_Appoint(0);
            schedule.List();
        }

    }
}
