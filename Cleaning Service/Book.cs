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
        private static List<Book> BookingList = new List<Book>();

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
            string buildingType = Console.ReadLine().ToUpper();
            Console.WriteLine("Business Name:");
            string businessName = Console.ReadLine();
            BookingList.Add(new Book(address, city, county, squareFootage, description, customerId, staffId, buildingType, businessName));
        }

        public static void UpdateDomestic()
        {
            Console.WriteLine("Enter Job GUID:");
            string domesticId = Console.ReadLine();
            var completeJob = BookingList.SingleOrDefault(r => Convert.ToString(r.Id) == domesticId);
            if (completeJob != null)
            {
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

        public static void ViewDomestic()
        {
            int x = 0;
            foreach (Book domestic in BookingList)
            {
                Console.WriteLine($"Booking {++x}\n{domestic}");
            }
        }

        public override string ToString()
        {
            return $"Property: {BusinessName} {Address} {City} {County} : {Id}\nType: {BusinessType} {SquareFootage}\nDate Booked: {Date}\nComplete: {Complete} at {Updated}";
        }
    }
}
