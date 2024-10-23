using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class Item
    {
        public string ItemName { get; set; }
        public decimal Value { get; set; }
        public DateTime PawnDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsLiquidated { get; set; }
    }
}
