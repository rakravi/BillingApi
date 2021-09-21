using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessHelper
{
    public static class Constants
    {
        public const string Drink = "BVG";
        public const string Food = "FD";
        public const string ServiceCharge = "SRV";

        //These rates can be made table driven and can be made configurable.
        public const int DrinkSrvCharge = 0;
        public const int FoodSrvCharge = 10;

    }
}
