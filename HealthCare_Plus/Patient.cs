using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Patient
    {
        public string PatientId { get; set; }

        public string FirstName { get; set;}

        public string LastName { get; set;}

        public DateTime DoB { get; set;}

        public string ContactNo { get; set;}

        public string Gender { get; set;}

        public string BloodGroup { get; set;}

        public string MajorDisease { get; set;}

        public string Address { get; set;}

        // create constructor
        
        public Patient(string PatientId, string FirstName, string LastName, DateTime DoB, 
            string ContactNo, string Gender, string BloodGroup, string MajorDisease, string Address)
        
        {
            this.PatientId = PatientId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DoB = DoB;
            this.ContactNo = ContactNo;
            this.Gender = Gender;
            this.BloodGroup = BloodGroup;
            this.MajorDisease = MajorDisease;
            this.Address = Address;

        }

        public Patient()
        {
        }


    }
}
