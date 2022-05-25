using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class Staff : User
    {
        // Values of Staff, inheriting from User
        public char Gender { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? Role { get; set; }
        // List to hold all Staff
        private static List<Staff> StaffMembers = new List<Staff>();

        // Constructor to initiate new Staff
        public Staff(string FirstName, string LastName, char Gender, string Email, string Telephone, string Role)
        {
            Id = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsAdmin = false;
            this.Gender = Gender;
            this.Email = Email.Contains('@') ? Email : "Email not valid, re-enter";
            this.Telephone = Telephone;
            this.Role = Role;
        }


        // Get details of Staff to be documented
        public static void AddStaff()
        {
            Console.WriteLine("Staff First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Staff Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Staff Gender:");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Email:");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Telephone:");
            string telephone = Console.ReadLine();
            Console.WriteLine("Staff Role:");
            string role = Console.ReadLine();
            // Add to List
            StaffMembers.Add(new Staff(firstName, lastName, gender, emailAddress, telephone, role));   
        }

        // Remove Staff from List
        public static void DeleteStaff()
        {
            Console.WriteLine("Enter Staff GUID: ");
            string staffId = Console.ReadLine();
            // Go through list and find ID of the Staff
            var toRemove = StaffMembers.SingleOrDefault(r => Convert.ToString(r.Id) == staffId);
            if (toRemove != null)
                StaffMembers.Remove(toRemove);
            else
                Console.WriteLine("No Staff Member Found");
        }

        // Loop through entire Staff List
        public static void StaffList()
        {
            int x = 0;
            foreach (Staff staff in StaffMembers)
            {
                Console.WriteLine($"Staff {++x}\n{staff}");
            }
        }

        // Custom Output
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Gender} : {Id} - {Role}\nContact: {Email} + {Telephone}";
        }

    }
}
