using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    internal interface IBook
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }

    }
}
