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
        public string userFullName { get; set; }
        public string Telephone { get; set; }
        public bool Gender { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? UserBirthday { get; set; }
        public byte? UserRole { get; set; }
        public string Password { get; set; }
    }
}
