using TravelLearning.Core.Models;

namespace TravelLearning.Core.Repositories
{
    public interface IContractRepository
    {
        Task<Contract> AddContractAsync(Contract contract);
        Task<Contract?> GetByIdAsync(int id);
    }
}
