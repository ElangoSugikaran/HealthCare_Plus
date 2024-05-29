using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Login_cls
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        //create constructor
        public Login_cls(string Email, string Password, string Role) 
        { 
            this.Email = Email;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
