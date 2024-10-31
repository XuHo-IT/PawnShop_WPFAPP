using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    internal class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserRealName { get; set; }
        public string EmailAddress { get; set; }
        public bool Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string CID { get; set; }
        public int UserRole { get; set; }
        
    }
}
