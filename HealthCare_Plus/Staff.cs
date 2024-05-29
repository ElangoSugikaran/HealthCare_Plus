using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Staff
    {
        public string StaffID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public string ContactNo { get; set; }

        public string Gender { get; set; }

        public string Role { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        // create constructors

        public Staff(string StaffID, string FirstName, string LastName, DateTime DoB, string ContactNo, string Gender,
            string Role, string Email, string Password, string Address) 
        { 
            this.StaffID = StaffID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DoB = DoB;
            this.ContactNo = ContactNo;
            this.Gender = Gender;
            this.Role = Role;
            this.Email = Email;
            this.Password = Password;
            this.Address = Address;

        }

        public Staff()
        {
        }
    }
}
