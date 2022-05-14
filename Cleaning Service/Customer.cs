using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Customer : User
    {
        public char Gender { get; set; }
        public string? Email { get; set; }
        public string Telephone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }

        private static List<Customer> Customers = new List<Customer>();

        public Customer(string FirstName, string LastName, char Gender, string Email, string Telephone, string Address, string City, string County)
        {
            Id = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsAdmin = false;
            this.Gender = Gender;
            this.Email = Email.Contains('@') ? Email : "Email not valid";
            this.Telephone = Telephone;
            this.Address = Address;
            this.City = City;
            this.County = County;
        }

        public static void CustomerList()
        {
            foreach (Customer customer in Customers)
            {
                customer.ToString();
            }
        }

        public override string ToString()
        {
            return $"Customer: {FirstName} {LastName} {Gender}\nContact: {Email} + {Telephone}\n{Address}, {City}, {County}";
        }
    }
}
