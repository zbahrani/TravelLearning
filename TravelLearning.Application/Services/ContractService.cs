using TravelLearning.Application.Dtos;
using TravelLearning.Core.Models;
using TravelLearning.Core.Repositories;

namespace TravelLearning.Application.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;
        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
            
        }
        public async Task<int> AddContractAsync(AddContractRequest addContract, CancellationToken cancellation = default)
        {
            ArgumentNullException.ThrowIfNull(addContract);
            if (string.IsNullOrWhiteSpace(addContract.CustomerName))
            {
                throw new ArgumentException("CustomerName is required.", nameof(addContract.CustomerName));
            }

            if (string.IsNullOrWhiteSpace(addContract.ServiceType))
            {
                throw new ArgumentException("ServiceType is required.", nameof(addContract.ServiceType));
            }

            if (addContract.Amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.", nameof(addContract.Amount));
            }

            var contract = new Contract
            {
                CustomerName = addContract.CustomerName.Trim(),
                ServiceType = addContract.ServiceType.Trim(),
                Amount = addContract.Amount,
                CreatedAt = DateTime.UtcNow,
                HotelName = addContract.HotelName?.Trim(),
                CheckIn = addContract.CheckIn,
                CheckOut = addContract.CheckOut,
                Origin = addContract.Origin?.Trim(),
                Destination = addContract.Destination?.Trim(),
                FlightNumber = addContract.FlightNumber?.Trim(),
                FlightDate = addContract.FlightDate
            };

            await _contractRepository.AddContractAsync(contract);

            return contract.Id;
        }
    }
}
