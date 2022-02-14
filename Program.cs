using System;
using System.Globalization;
namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.Insert_Appoint("Walk my dog", "15, 5, 2020");
            Console.WriteLine();
            schedule.List();
        }

    }
}
