using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public interface IAccountService
    {
       


        /// <summary>
        /// Create User Async
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        Task<_User> CreateUserAsync(_User newUser);


        /// <summary>
        /// Delete User Async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteUserAsync(int id);

        /// <summary>
        /// Get User By Id Async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<_User> GetUserByIdAsync(int id);


        /// <summary>
        /// Get Users Async (No one can have access)
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<_User>> GetUsersAsync();

        /// <summary>
        /// Use to treat token
        /// </summary>
        /// <param name="loginname"></param>
        /// <returns></returns>
        Task<_User> GetUserByloginNameAsync(string loginname);

        /// <summary>
        /// Modify User Async
        /// </summary>
        /// <param name="modifiedUser"></param>
        /// <returns></returns>
        Task<_User> ModifyUserAsync(_User modifiedUser);


    }
}