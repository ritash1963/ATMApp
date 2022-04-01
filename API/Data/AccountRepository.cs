using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API.Data
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;
        public AccountRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Account> GetAccount(int pin)
        {
           var card = await _context.CardsTbl.FirstOrDefaultAsync(u => u.PIN == pin);
           return await _context.AccountsTbl.FirstOrDefaultAsync(c=> c.Id == card.AccountId);
        }

        public async Task<List<Operation>> GetOperations(int accId)
        {
            return await _context.OperationsTbl.Where(c => c.AccountId == accId).OrderByDescending(c => c.CreDate).Take(5).ToListAsync();
        }

        public async Task<Account> GetClientAccount(int id)
        {
           return await _context.AccountsTbl.FirstOrDefaultAsync(c=> c.Id == id);
        }
     }
}
