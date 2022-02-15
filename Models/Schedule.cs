﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
     class Schedule
     {
        private List<Appointment> Appointments = new List<Appointment>();

        //              Methods

        //Return Apointments size
        public int Amount { get { return Appointments.Count; } }

        //Insert new objet in Appointments
        public void Insert_Appoint(string content, string date)
        {
            Appointment Appoint = new(content, date);
            Appointments.Add(Appoint);
        }

        //Remove an appointment by index
        public void Remove_Appoint(int index)
        {
            Appointments.RemoveAt(index);
        }

        //Show all apointments
        public void List()
        {
            Console.WriteLine("Your schedule:\n");
            Console.WriteLine(("").PadRight(Console.WindowWidth, '-'));
            for (int i = 0; i < Appointments.Count; i++)
            {
                Console.WriteLine($"{i + 1}. \t{ Appointments[i].Content}\t{ DateTime.Parse(Appointments[i].Date).ToString("dd/MM/yyyy") }" );
            }
            Console.WriteLine(("").PadRight(Console.WindowWidth, '-'));
            Console.WriteLine("\n");
        }

        //Edits content of an appointment choose by index
        public void Edit_Content(int index, string new_content)
        {
            Appointments[index].Content = new_content;
        }

        //Edits date of an appointment choose by index
        public void Edit_Date(int index, string new_date)
        {
            Appointments[index].Date = new_date;
        }

    }
}