using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal class Customer : User
    {
        public char Gender { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }

        public Customer(string FirstName, string LastName, char Gender, string Email, string Telephone, string Address, string City, string County)
        {
            Id = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsAdmin = false;
            this.Gender = Gender;
            this.Email = Email;
            this.Telephone = Telephone;
            this.Address = Address;
            this.City = City;
            this.County = County;
        }

        public override string ToString()
        {
            return $"Customer Information: {FirstName} {LastName}\n{Gender}\nContact: {Email} + {Telephone}\n{Address}, {City}, {County}";
        }
    }
}
