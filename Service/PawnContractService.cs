using BussinessObject;
using Repository;

namespace Service
{
    public class PawnContractService : IPawnContractRepository
    {
        private readonly IPawnContractRepository PawnContractRepository;

        public PawnContractService(IPawnContractRepository PawnContractRepository)
        {
            this.PawnContractRepository = PawnContractRepository;
        }

        public List<PawnContract> GetAllPawnContracts()
        {
            return PawnContractRepository.GetAllPawnContracts();
        }

        public PawnContract GetPawnContractById(int id)
        {
            return PawnContractRepository.GetPawnContractById(id);
        }

        public void UpdatePawnContract(PawnContract PawnContract)
        {
            PawnContractRepository.UpdatePawnContract(PawnContract);
        }

        public void DeletePawnContract(int id)
        {
            PawnContractRepository.DeletePawnContract(id);
        }
        public int AddPawnContract(PawnContract PawnContract)
        {
            return PawnContractRepository.AddPawnContract(PawnContract);
        }

        public List<PawnContract> GetContractsByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
