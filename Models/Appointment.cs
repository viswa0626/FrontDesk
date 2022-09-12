using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontDesk.Models
{
    public class Appointment
    {

        public string Name { get; set; }
        public string Severity { get; set; }
        //TODO: change int to date
        public string Date { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
