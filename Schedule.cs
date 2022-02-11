using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
     class Schedule
     {
        private List<string> Appointment = new List<string>();
        private List<DateTime> Dates = new List<DateTime>();

        public int Amount { get { return Appointment.Count; } }

        public void Insert_Appoint(string element, string date)
        {
            Appointment.Add(element);
            Dates.Add(DateTime.Parse(date));
        }

        public void Delete_Appoint(int index)
        {
            Appointment.RemoveAt(index);
            Dates.RemoveAt(index);
        }

        public void List()
        {
            Console.WriteLine(("\n").PadRight(Console.WindowWidth, '-'));
            for (int i = 0; i < Appointment.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Appointment[i]} \t {Dates[i]}" );
            }
            Console.WriteLine(("").PadRight(Console.WindowWidth, '-'));
        }
    }
}
