using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class BillDAO
    {
        private static BillDAO? instance = null;
        private static readonly object instanceLock = new object();
        private readonly PawnShopContext _context;

        public static BillDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BillDAO();
                    }
                    return instance;
                }
            }
        }

        public BillDAO()
        {
            _context = new PawnShopContext();
        }
        public List<Bill> GetItems()
        {
            return _context.Bills.ToList();

        }
    }
}
