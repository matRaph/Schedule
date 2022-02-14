using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
     class Schedule
     {
        private List<Appointment> Appointments = new List<Appointment>();

        public int Amount { get { return Appointments.Count; } }

        public void Insert_Appoint(string element, string date)
        {
            if (date == null)
            {
                Appointment Appoint = new(element);
                Appointments.Add(Appoint);
            }
            else
            {
                Appointment Appoint = new(element, date);
                Appointments.Add(Appoint);
            }
        }


        public void Delete_Appoint(int index)
        {
            Appointments.RemoveAt(index);
        }

        public void List()
        {
            Console.WriteLine("Your schedule:\n");
            Console.WriteLine(("\n").PadRight(Console.WindowWidth, '-'));
            for (int i = 0; i < Appointments.Count; i++)
            {
                Console.WriteLine($"{i + 1}.\t{Appointments[i].Show_Appoint('c')}\t{DateTime.Parse(Appointments[i].Show_Appoint('d'))}" );
            }
            Console.WriteLine(("").PadRight(Console.WindowWidth, '-'));
        }
        /*public void Edit(int index, string newAppoint, string newDate)
        {
            Appointment[index] = newAppoint;
            Dates[index] = DateTime.Parse(newDate);
        }
        public void Show_Appoint(int index)
        {
            Console.WriteLine($"{index + 1}.\t{Appointment[index]}\t{Dates[index]}");
        }

        //Sorts
        
        public void Sort_alpha_asc()
        {
            Appointment.Sort();
        }
        */
    }
}
