using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public interface IAccountService
    {



        /// <summary>
        /// Create User 
        /// </summary>
        /// <param name="newUser"> _User(BO) </param>
        /// <returns>_User(BO) or throw new InsertSQLFailureException</returns>
        Task<_User> CreateUserAsync(_User newUser);


        /// <summary>
        /// Delete User Account by Id    
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteUserAsync(int id);

        /// <summary>
        /// Get User Account By Id 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>IEnumerable _User(BO) or Throw New NotFoundException</returns>
        Task<_User> GetUserByIdAsync(int id);


        /// <summary>
        /// Get Users Accounts
        /// </summary>
        /// <returns>BO _User or Throw New NotFoundException</returns>
        Task<IEnumerable<_User>> GetUsersAsync();

        /// <summary>
        /// Get User Account by LoginName
        /// </summary>
        /// <param name="loginname">LoginName</param>
        /// <returns>BO _User or Throw New NotFoundException</returns>
        Task<_User> GetUserByloginNameAsync(string loginname);

        /// <summary>
        /// Modify User Account
        /// </summary>
        /// <param name="modifiedUser">_User(BO)</param>
        /// <returns>BO _User or Throw New NotFoundException</returns>
        Task<_User> ModifyUserAsync(_User modifiedUser);


    }
}