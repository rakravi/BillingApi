using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessModel
{
    public class BillDetails
    {
        public float ServiceCharge { get; set; }
        public float TaxCharge { get; set; }
        public float Total { get; set; }
    }
}
