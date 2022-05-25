using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class Admin : User
    { 
        // Values Unique to Admin
        public string Username { get; set; }
        public string Password { get; set; }


        // Constructor to initiate values of Admin
        public Admin(string FirstName, string LastName, string Username, string Password)
        {
            Id = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsAdmin = true;
            this.Username = Username;
            this.Password = Password;
        }
    }
}
