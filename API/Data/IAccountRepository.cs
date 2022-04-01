using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public interface IAccountRepository
    {
      void Add<T>(T entity) where T: class;
      Task<bool> SaveAll();
      Task<List<Operation>> GetOperations(int accId);
      Task<Account> GetAccount(int pin);   
      Task<Account> GetClientAccount(int id);   
    }
}