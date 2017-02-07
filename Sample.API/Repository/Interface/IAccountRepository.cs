using Sample.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.API.Repository.Interfaces
{
    public interface IAccountRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserAccount>> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserAccount> GetUserAccount(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<UserAccount> AddAsync(UserAccount item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Remove(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<bool> UpdateAsync(UserAccount item);
    }
}
