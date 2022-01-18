using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita.Structures
{
    public struct CountingHouse
    {
        public string Name { get; set; }
        public List<Bill> BillList { get; set; }

        public CountingHouse(string name) 
        {
            Name = name;
            BillList = new List<Bill>();
        }

       // public void AddBillToList(Bill bill)
       // {
       //     BillList.Add(bill);
      //  }
        public int TotalAmountOfBill()
        {
            return BillList.Count;
        }

        public int TotalSumOfBills(List<Bill> bills)
        {
            int sum = 0;
            foreach (var item in bills)
            {
                sum += item.TotalBill;
            }
            return sum;
        }
    }
}
