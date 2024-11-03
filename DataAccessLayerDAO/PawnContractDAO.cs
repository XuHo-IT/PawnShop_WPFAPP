using BussinessObject;

namespace DataAccessLayer
{
    public class PawnContractDAO
    {
        private static PawnContractDAO? instance = null;
        private static readonly object instanceLock = new object();
        private readonly PawnShopContext _context;

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
