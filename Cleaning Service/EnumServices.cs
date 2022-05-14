using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    /* Used for the type of cleaning that the service offers */

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

        public static void Types()
        {
            Console.WriteLine("Cleaning Services");

            foreach (var type in Enum.GetValues(typeof(CleaningService)))
            {
                Console.WriteLine(type);
            }

            Console.WriteLine("Repair Services");

            foreach (var type in Enum.GetValues(typeof(RepairService)))
            {
                Console.WriteLine(type);
            }
        }
    }
}
