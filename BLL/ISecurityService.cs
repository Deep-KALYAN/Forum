using Domain.Entites;
using System.Threading.Tasks;

namespace BLL
{
    public interface ISecurityService
    {
        /// <summary>
        /// Generate the Token 
        /// </summary>
        /// <param name="username">nickname</param>
        /// <param name="password">password</param>
        /// <returns>JWT Token or Throw ForbiddenAccessException or Throw AuthentificationFailException</returns>
        Task<string> SigningAsync(string login_name, string password);
    }
}