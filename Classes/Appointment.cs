using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Appointment
    {
        public string Content { get; set; }
        public string Date { get; set; }

        //Construct
        public Appointment(string Content, string Date)
        {
            this.Content = Content;
            this.Date = Date;
        }

        //Overriding ToString() to return the properties of the appointment
        public override string ToString()
        {
            return Content + "\t" + DateTime.Parse(Date).ToString("dd/MM/yyyy");
        }
    }
}
