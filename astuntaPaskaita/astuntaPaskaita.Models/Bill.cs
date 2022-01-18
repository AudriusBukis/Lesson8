using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita.Structures
{
    public struct Bill
    {
        public Guid BillNumber { get; private set; }

        public int TotalBill { get; set; }

        public Bill(int totalBill)
        { 
            BillNumber = Guid.NewGuid();
            TotalBill = totalBill;
        }
    }
}
