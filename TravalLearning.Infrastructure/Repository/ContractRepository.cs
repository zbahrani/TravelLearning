using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using TravelLearning.Core.Models;
using TravelLearning.Core.Repositories;

namespace TravelLearning.Infrastructure.Repository
{
    public class ContractRepository : IContractRepository
    {
        private readonly AppDbContext _context;
        public ContractRepository(AppDbContext dbContext)
        {
            _context = dbContext;          
        }
        public async Task<Contract> AddContractAsync(Contract contract)
        {
            await _context.Contracts.AddAsync(contract);
            await _context.SaveChangesAsync();
            return contract;
        }

        public async Task<Contract?> GetByIdAsync(int id)
        {
           return await _context.Contracts.FindAsync(id);
        }
    }
}
