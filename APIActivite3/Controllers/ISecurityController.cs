using Domain.DTO.Requestes.Security;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    public interface ISecurityController
    {
        /// <summary>
        /// Login to Generate Jwt Token
        /// </summary>
        /// <param name="authentificationRequestDTO">AuthentificationRequestDTO</param>
        /// <returns>GenerateJwtToken(login_name, List of Roles, user id) or AuthentificationFailure</returns>
        Task<IActionResult> Login([FromBody] AuthentificationRequestDTO authentificationRequestDTO);
    }
}