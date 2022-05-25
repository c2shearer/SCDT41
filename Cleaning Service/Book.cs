using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.EnumProperties;

namespace Cleaning_Service
{
    public class Book : IBooking
    {
        // Implement from Interface
        // Properties of Booking
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string County { get; set; }
        public float SquareFootage { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }
        public DateTime Date { get; set; }
        public DateTime Updated { get; set; }
        public string OwnerId { get; set; }
        public float EmployeeTime { get; set; }
        public string EmployeeId { get; set; }
        public string BusinessType { get; set; }
        public string BusinessName { get; set; }
        // Create List of all Bookings
        private static List<Book> BookingList = new List<Book>();

        // Constructor to initiate values of Booking
        public Book(string Address, string City, string County, 
            float SquareFootage, string Description, string OwnerId,
            string EmployeeId, string BusinessType, string BusinessName)
        {
            Id = Guid.NewGuid();
            this.Address = Address;
            this.City = City;
            this.County = County;
            this.SquareFootage = SquareFootage;
            this.Description = Description;
            Complete = false;
            Date = DateTime.Now;
            Updated = DateTime.Now;
            this.OwnerId = OwnerId;
            this.EmployeeId = EmployeeId;
            this.BusinessType = BusinessType;
            this.BusinessName = BusinessName;
        }

        // Get Booking inputs
        public static void AddDomestic()
        {
            Console.WriteLine("Building Address:");
            string address = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("County:");
            string county = Console.ReadLine();
            Console.WriteLine("Square Footage of Building:");
            float squareFootage = float.Parse(Console.ReadLine());
            Console.WriteLine("Description of Job:");
            string description = Console.ReadLine();
            Console.WriteLine("Customer GUID:");
            string customerId = Console.ReadLine();
            Console.WriteLine("Staff GUID(s):");
            string staffId = Console.ReadLine();
            Console.WriteLine("Business Type:");
            EnumProperties.DomesticTypes();
            EnumProperties.CommericalTypes();
            string buildingType = Console.ReadLine().ToUpper();
            Console.WriteLine("Business Name:");
            string businessName = Console.ReadLine();
            // Add to Booking List
            BookingList.Add(new Book(address, city, county, squareFootage, description, customerId, staffId, buildingType, businessName));
        }

        // Update Booking from GUID
        public static void UpdateDomestic()
        {
            Console.WriteLine("Enter Job GUID:");
            string domesticId = Console.ReadLine();
            // Filter list to find ID of Booking
            var completeJob = BookingList.SingleOrDefault(r => Convert.ToString(r.Id) == domesticId);
            if (completeJob != null)
            {
                // Update Information
                Console.WriteLine("Enter Employee Hours on Record");
                float employeeTime = float.Parse(Console.ReadLine());
                completeJob.EmployeeTime = employeeTime;
                Console.WriteLine($"Updated Job to Complete: {completeJob.Complete = true} {completeJob.Updated = DateTime.Now}");
            }
            else
            {
                Console.WriteLine("Job not found");
            }
        }

        // Loop through entire Booking List
        public static void ViewDomestic()
        {
            int x = 0;
            foreach (Book domestic in BookingList)
            {
                Console.WriteLine($"Booking {++x}\n{domestic}");
            }
        }

        // Custom Output
        public override string ToString()
        {
            return $"Property: {BusinessName} {Address} {City} {County} : {Id}\nType: {BusinessType} {SquareFootage} - {Description}\nOwner: {OwnerId}\nStaff: {EmployeeId}\nDate Booked: {Date}\nComplete: {Complete} at {Updated}";
        }
    }
}
