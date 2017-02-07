using Sample.API.Models;
using Sample.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API.Repository
{
    public sealed class AccountRepository : IAccountRepository
    {
        private readonly List<UserAccount> _account;
        private int _nextId;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Await.Warning", "CS4014:Await.Warning")]
        public AccountRepository()
        {
            _account = new List<UserAccount>();
            _nextId = 1;

            AddAsync(new UserAccount { Name = "Rahul Dravid", Address = "128 Square Avenue", Email = "rahul@dravid.com", Postal = "12800" }).Wait();
            AddAsync(new UserAccount { Name = "Saurav Ganguly", Address = "256 Off Avenue", Email = "saurav@ganguly.com", Postal = "25600" }).Wait();
            AddAsync(new UserAccount { Name = "Virat Kohli", Address = "384 Straight Avenue", Email = "virat@kohli.com", Postal = "38400" }).Wait();

            
        }

        public async Task<IEnumerable<UserAccount>> GetAll()
        {
            return await Task.FromResult(_account);
        }

        public async Task<UserAccount> GetUserAccount(int id)
        {
            return await Task.FromResult(_account.FirstOrDefault(p => p.Id == id));
        }

        public async Task<UserAccount> AddAsync(UserAccount item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            item.Id = _nextId++;
            _account.Add(item);
            return await Task.FromResult(item);
        }

        public void Remove(int id)
        {
            _account.RemoveAll(p => p.Id == id);
        }

        public async Task<bool> UpdateAsync(UserAccount item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            var index = _account.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            _account.RemoveAt(index);
            _account.Add(item);

            return await Task.FromResult(true);
        }
    }
}
