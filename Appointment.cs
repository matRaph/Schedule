using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Appointment
    {
        private string Content { get; set; }
        private string Date { get; set; }

        //Constructs
        public Appointment(string Content, string Date)
        {
            this.Content = Content;
            this.Date = Date;
        }
        public Appointment(string Content)
        {
            this.Content = Content;
            Date = null;
        }

        //Methods
        public string Show_Appoint(char type)
        {
            if (type == 'c')
            {
                return Content;
            }
            else
            {
                return Date;
            }
        }


    }
}
