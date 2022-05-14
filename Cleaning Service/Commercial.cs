using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cleaning_Service.EnumProperties;

namespace Cleaning_Service
{
    public class Commercial : IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public CommercialType HouseType { get; set; }
        public string? HouseName { get; set; }
        public float SqaureFootage { get; set; }

        public Commercial(string Address, string City, string County, CommercialType HouseType, string HouseName, float SqaureFootage)
        {
            Id = Guid.NewGuid();
            this.Address = Address; 
            this.City = City;
            this.County = County;
            this.HouseType = HouseType;
            this.HouseName = HouseName;
            this.SqaureFootage = SqaureFootage;
        }

        public override string ToString()
        {
            return $"Commerical Property: {Address} {City} {County}\nType: ${HouseType} {SqaureFootage}";
        }
    }
}
