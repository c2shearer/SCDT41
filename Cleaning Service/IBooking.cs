using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal interface IBooking
    {
        // Interface used in-case other bookings are required
        // later on in development
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
        public string EmployeeId { get; set; }
        public float EmployeeTime { get; set; }
    }
}
