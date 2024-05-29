using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Medication
    {
        public string MedicationId { get; set; }

        public string PatientName { get; set; }

        public string DoctorName { get; set; }

        public string MedicineName { get; set; }

        public string MedicineDosage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Frequcey { get; set; }

        public string MedicineCharge { get; set; }


        //create constructor

        public Medication(string MedicationId, string PatientName, string DoctorName, string MedicineName, 
            string MedicineDosage, DateTime StartDate, DateTime EndDate, string Frequcey, string MedicineCharge) 
        {
            this.MedicationId = MedicationId;
            this.PatientName = PatientName;
            this.DoctorName = DoctorName;
            this.MedicineName = MedicineName;
            this.MedicineDosage = MedicineDosage;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Frequcey = Frequcey;
            this.MedicineCharge = MedicineCharge;
        }

        public Medication()
        {
        }
    }
}
