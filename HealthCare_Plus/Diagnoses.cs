using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Diagnoses
    {
        public string DiagnosesId { get; set; }

        public string PatientId { get; set; }

        public string PatientName { get; set; }

        public DateTime Date { get; set; }

        public string DiagnosesDescription { get; set; }

        //create contructor

        public Diagnoses(string DiagnosesId, string PatientId, string PatientName, DateTime Date, string DiagnosesDescription)
        {
            this.DiagnosesId = DiagnosesId;
            this.PatientId = PatientId;
            this.PatientName = PatientName;
            this.Date = Date;
            this.DiagnosesDescription = DiagnosesDescription;
        }

        public Diagnoses()
        {
        }
    }
}
