using Domain.DTO;
using Domain.DTO.Requestes.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    public interface IUserAccountController
    {
        /// <summary>
        /// To Create User Account
        /// </summary>
        /// <param name="newUser">CreateUserRequestDTO</param>
        /// <returns>CreateUserResponseDTO or BadRequest</returns>
        Task<IActionResult> CreateUser([FromBody] CreateUserRequestDTO newUser);

        /// <summary>
        /// To Delete User Account by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>NoContent or NotFound</returns>
        Task<IActionResult> DeleteUser(int id);

        /// <summary>
        /// To Get User Account by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>OK GetUsersResponseDTO or NotFound</returns>
        Task<IActionResult> GetUserById([FromRoute] int id);

        /// <summary>
        /// To Get all Users Accounts
        /// </summary>
        /// <returns>OK GetUsersResponseDTO List or NotFound</returns>
        Task<IActionResult> GetUsers();

        /// <summary>
        /// To Modify User Account
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="newUser">UpdateUserRequestDTO</param>
        /// <returns>OK UpdateUserResponseDTO or BadRequest</returns>
        Task<IActionResult> ModifieUser([FromRoute] int id, [FromBody] UpdateUserRequestDTO newUser);
    }
}