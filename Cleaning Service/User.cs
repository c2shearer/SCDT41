using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class User
    {
        // Inherit to Admin, Customer and Staff
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }  
        public bool IsAdmin { get; set; }
    }
}
