using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
     class Schedule
     {
        static List<Appointment> Appointments = new();

        //              Methods

        //Return Apointments size
        public static int Amount { get { return Appointments.Count; } }

        //Insert new objet in Appointments
        public void Insert_Appoint(string content, string date)
        {
            Appointment Appoint = new(content, date);
            Appointments.Add(Appoint);
        }

        //Remove an appointment by index
        public void Remove_Appoint(int index)
        {
            Appointments.RemoveAt(index -1);
        }

        public static string List_Appoints()
        {
            string returnVar = "";
            if (Appointments.Count <= 0)
            {
                returnVar += "You don't have any appointments yet" + Environment.NewLine;
            }
            else
            {
                returnVar += "Your appointments:" + Environment.NewLine;
            }

            for (int i = 0; i < Appointments.Count; i++)
            {
                returnVar += $"{i + 1}. \t{ Appointments[i].ToString()}" + Environment.NewLine;
            }

            return returnVar;
        }

        //Edits content of an appointment choose by index
        public static void Edit_Content(int index , string new_content)
        {
            Appointments[index - 1].Content = new_content;
        }

        //Edits date of an appointment choose by index
        public static void Edit_Date(int index, string new_date)
        {
            Appointments[index - 1].Date = new_date;
        }

        //Using Comparison<T> delegate to sort appointments by alpha
        public static void Sort_Alpha()
        {
            Appointments.Sort((x, y) => x.Content.CompareTo(y.Content));
        }

        //Using Comparison<T> delegate to sort appointments by date
        public static void Sort_Date()
        {
            Appointments.Sort((x, y) => DateTime.Parse(x.Date).CompareTo(DateTime.Parse(y.Date)));

        }
    }
}
