using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPawnContractRepository
    {
        List<PawnContract> GetAllPawnContracts();
        PawnContract GetPawnContractById(int id);
        List<PawnContract> GetContractsByUserId(int userId);
        int AddPawnContract(PawnContract pawnContract);
        void UpdatePawnContract(PawnContract pawnContract);
        void DeletePawnContract(int id);
    }
}
