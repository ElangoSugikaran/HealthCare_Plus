using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Theater
    {
        public string TheaterId { get; set; }

        public string PatientName { get; set; }

        public string DoctorName { get; set; }

        public DateTime ScheduledDate { get; set; }

        public string Status { get; set; }

        public string Location { get; set; }

        // create constructor
        public Theater(string TheaterId, string PatientName, string DoctorName, DateTime ScheduledDate, string Status, string Location)
        { 
            this.TheaterId = TheaterId;
            this.PatientName = PatientName;
            this.DoctorName = DoctorName;
            this.ScheduledDate = ScheduledDate;
            this.Status = Status;
            this.Location = Location;
        }

        public Theater()
        {
        }
    }
}
