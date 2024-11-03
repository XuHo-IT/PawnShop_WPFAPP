using BussinessObject;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class PawnContractRepository
    {
    

        public void SendToAdminForApproval(Item item) => PawnContractDAO.Instance.SendToAdminForApproval(item);

        public List<Item> GetPendingItems() => PawnContractDAO.Instance.GetPendingItems();


        public void ApproveItem(Item item, int userId) => PawnContractDAO.Instance.ApproveItem(item, userId);
       

        public void RejectItem(Item item) => PawnContractDAO.Instance.RejectItem(item);
        
    }
}
