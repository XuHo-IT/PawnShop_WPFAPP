using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class PawnContract
    {
        public String ContractNumber { get; set; }
        public String UserRealName{ get; set; }
        public String Item { get; set; }
        public String PawnMoney { get; set; }
        public String PhoneNumber { get; set; }
        public float Interest { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
