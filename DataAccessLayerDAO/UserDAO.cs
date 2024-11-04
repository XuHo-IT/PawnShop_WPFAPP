using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAO
    {
        private static UserDAO? instance = null;
        private static readonly object instanceLock = new object();
        private readonly PawnShopContext _context;

        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public UserDAO()
        {
            _context = new PawnShopContext();
        }
        public List<User> GetUsers()
        {
            return _context.User.ToList();

        }
        public User GetUseryId(int userId)
        {
          
            return _context.User.FirstOrDefault(user => user.UserID == userId); 
        }
        public User GetUserByEmailAndPassword(string email, string password)
        {
            
            return _context.User.FirstOrDefault(u => u.EmailAddress == email && u.Password == password);
        }
    }
}
