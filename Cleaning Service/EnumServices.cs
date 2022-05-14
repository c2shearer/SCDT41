using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    public class EnumServices
    {
        public enum CleaningService
        {
            VACUUMING,
            MOPPING,
            DUSTING,
            POLISHING,
            BROOMING
        }

        public enum RepairService
        {
            FIREDAMAGE,
            SMOKEDAMAGE,
            WATERDAMAGE
        }
    }
}
