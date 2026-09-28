using TravelLearning.Application.Dtos;

namespace TravelLearning.Application.Services
{
    public interface IContractService
    {
        Task<int> AddContractAsync(AddContractRequest addContract, CancellationToken cancellation = default);
    }
}
