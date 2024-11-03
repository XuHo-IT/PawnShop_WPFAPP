

using BussinessObject;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace DataAccessLayer
{
    public class PawnContractDAO
    {
        private static PawnContractDAO? instance = null;
        private static readonly object instanceLock = new object();
        private PawnShopContext _context;

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

        private PawnContractDAO(){  }

        public List<PawnContract> GetAllPawnContracts()
        {
            _context = new PawnShopContext();
            List<PawnContract> list = _context.PawnContracts.ToList();
            Console.WriteLine($"Retrieved {list.Count} pawn contracts.");
            return list;
        }
        public PawnContract GetPawnContractById(int id)
        {
            using (_context = new PawnShopContext())
            {
                return _context.PawnContracts.Find(id);
            }
        }
        public List<PawnContract> GetContractsByUserId(int userId)
        {
            using (var context = new PawnShopContext())
            {
                return context.PawnContracts
                    .Where(pc => pc.UserId == userId)
                    .ToList();
            }
        }

        public int AddPawnContract(PawnContract pawnContract)
        {
            _context.PawnContracts.Add(pawnContract);
            _context.SaveChanges();
            return pawnContract.ContractId; // Return the newly generated ID
        }

        public void UpdatePawnContract(PawnContract pawnContract)
        {
            _context.PawnContracts.Update(pawnContract);
            _context.SaveChanges();
        }

        public void DeletePawnContract(int id)
        {
            var contract = _context.PawnContracts.Find(id);
            if (contract != null)
            {
                _context.PawnContracts.Remove(contract);
                _context.SaveChanges();
            }
        }
    }
}