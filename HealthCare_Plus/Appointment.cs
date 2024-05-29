using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Appointment
    {
        public string AppointmnetID { get; set; }

        public string PatientName { get; set; }

        public string DoctorName { get; set;}

        public DateTime Date { get; set;}

        public string Purpose { get; set; }

        public string Status { get; set; }

        public string AppointmentCharge { get; set; }

        //create constructor
        public Appointment(string AppointmnetID, string PatientName, string DoctorName, DateTime Date, string Purpose, string Status, string AppointmentCharge) 
        {
            this.AppointmnetID = AppointmnetID;
            this.PatientName = PatientName;
            this.DoctorName = DoctorName;
            this.Date = Date;
            this.Purpose = Purpose;
            this.Status = Status;
            this.AppointmentCharge = AppointmentCharge;

        }

        public Appointment() 
        { }
    }
}
