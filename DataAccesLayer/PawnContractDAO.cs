using BussinessObject;
using Repository;
using System;

namespace DataAccessLayer
{
    public class PawnContractDAO
    {
        private static PawnContractDAO? instance = null;
        private static readonly object instanceLock = new object();
        private readonly PawnShopContext _context;  // Changed to readonly

        public static PawnContractDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PawnContractDAO();
                    }
                    return instance;
                }
            }
        }

        public PawnContractDAO()
        {
            _context = new PawnShopContext();
        }

        public void AddContract(PawnContract contract)
        {
            _context.PawnContracts.Add(contract);
            _context.SaveChanges();
        }

        public PawnContract? GetContractById(int contractId)
        {
            return _context.PawnContracts.Find(contractId);
        }
    }
}
