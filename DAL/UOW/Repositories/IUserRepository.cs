using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.UOW.Repositories
{
    public interface IUserRepository : IGenericRepository<_User>
    {
        //Task<_User> CreateAsync(_User user);
        //Task<bool> DeleteAsync(int id);
        //Task<IEnumerable<_User>> GetAllAsync();
        //Task<_User> GetByIdAsync(int id);
        //Task<_User> UpdateAsync(_User user);
        Task<_User> GetUserBylogin_NameAsync(string loginname);
    }
}