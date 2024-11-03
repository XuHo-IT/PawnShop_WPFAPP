using BussinessObject;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PawnContractRepository : IPawnContractRepository
        
    {
        public PawnContractRepository() { }
        public List<PawnContract> GetAllPawnContracts() => PawnContractDAO.Instance.GetAllPawnContracts();
        public PawnContract GetPawnContractById(int id) => PawnContractDAO.Instance.GetPawnContractById(id);

        public List<PawnContract> GetReservationsByUserId(int userid) => PawnContractDAO.Instance.GetContractsByUserId(userid);

        public int AddPawnContract(PawnContract PawnContract) => PawnContractDAO.Instance.AddPawnContract(PawnContract);

        public void UpdatePawnContract(PawnContract PawnContract) => PawnContractDAO.Instance.UpdatePawnContract(PawnContract);

        public void DeletePawnContract(int id) => PawnContractDAO.Instance.DeletePawnContract(id);

        public List<PawnContract> GetContractsByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}