using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.EnumProperties;

namespace Cleaning_Service
{
    public class Domestic : IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string County { get; set; }
        public DomesticType BusinessType { get; set; }
        public string BusinessName { get; set; }
        public float SquareFootage { get; set; }

        public Domestic(string Address, string City, string County, DomesticType BusinessType, string BusinessName, float SquareFootage)
        {
            Id = Guid.NewGuid();
            this.Address = Address;
            this.City = City;
            this.County = County;
            this.BusinessType = BusinessType;
            this.BusinessName = BusinessName;
            this.SquareFootage = SquareFootage;
        }

        public override string ToString()
        {
            return $"Domestic Property: {BusinessName} {Address} {City} {County}\nType: ${BusinessType} {SquareFootage}";
        }
    }
}
