using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Service
{
    /* Used for the type of property that the service offers */

    public class Enums
    {
        public enum ResidentType
        {
            DEATCHED,
            SEMIDEATCHED,
            TERRACED,
            BUNGALOW,
            FLAT,
            APARTMENT
        }

        public enum CommercialType
        {
            OFFICE,
            WAREHOUSE,
            FACTORY,
            INDUSTRIAL_UNIT,
            RETAIL
        }
    }
}
