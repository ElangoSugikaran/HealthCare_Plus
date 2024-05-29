using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Doctor
    {
        public string DoctorID { get; set; }

        public string FirstName { get; set;}

        public string LastName { get; set;}

        public string Specialization { get; set;}

        public string Qualification { get; set;}

        public DateTime AvailabilitySchedule { get; set;}

        public string YearOfExperiences { get; set;}

        public string Status { get; set;}

        public string Gender { get; set;}

        public string ContactNo { get; set;}

        public DateTime DoB { get; set; }

        public string Email { get; set;}


        public string Address { get; set;}


        //create constructor

        public Doctor(string DoctorID, string FirstName, string LastName, string Specialization, string Qualification,
           DateTime AvailabilitySchedule, string YearOfExperiences, string Status,  string Gender, string ContactNo,
           DateTime DoB, string Email, string Address)
        {
            this.DoctorID = DoctorID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Specialization = Specialization;
            this.Qualification = Qualification;
            this.AvailabilitySchedule = AvailabilitySchedule;
            this.YearOfExperiences = YearOfExperiences;
            this.Status = Status;
            this.Gender = Gender;
            this.ContactNo = ContactNo;
            this.DoB = DoB;
            this.Email = Email;
            this.Address = Address;


        }

        public Doctor()
        {
        }
    }
}
