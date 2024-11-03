using BussinessObject;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class PawnContractRepository
    {
        private static PawnContractRepository? instance = null;
        private static readonly object instanceLock = new object();
        private readonly PawnShopContext _context;

        public static PawnContractRepository Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PawnContractRepository();
                    }
                    return instance;
                }
            }
        }

        private PawnContractRepository()
        {
            _context = new PawnShopContext(); 
        }

        public void SendToAdminForApproval(Item item) 
        {
            _context.Item.Add(item);
            _context.SaveChanges();
        }

        public List<Item> GetPendingItems() 
        {
            return _context.Item.Where(i => !i.IsApproved).ToList(); 
        }

        public void ApproveItem(Item item, int userId) 
        {
            var contract = new PawnContract
            {
                ItemId = item.ItemId,
                UserId = userId,
                LoanAmount = item.Value,
                ContractDate = DateTime.Now,
                ExpirationDate = item.ExpirationDate
            };

            PawnContractDAO.Instance.AddContract(contract);
            item.IsApproved = true; 
            _context.SaveChanges();
        }

        public void RejectItem(Item item) 
        {
            _context.Item.Remove(item);
            _context.SaveChanges();
        }
    }
}
