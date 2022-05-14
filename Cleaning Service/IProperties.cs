using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal interface IProperties
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
    }
}
