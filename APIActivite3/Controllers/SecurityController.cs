using BLL;
using Domain.DTO.Requestes.Security;
using Domain.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    [ApiController]
    [Route("api/account")]
  
    public class SecurityController : ControllerBase
    { 
        private readonly ISecurityService _securityService;
       
        public SecurityController(ISecurityService securityService)
        {
            _securityService = securityService;

        }

        //[HttpGet("{loginname}")]
        //public async Task<IActionResult> GetUserByLoginname(string loginname)
        //{
        //    _User user = await _accountService.GetUserByloginNameAsync(loginname);
        //    if (user == null) return NotFound();
        //    return Ok(user);

        //}

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthentificationRequestDTO authentificationRequestDTO)
        {            
            string token = await _securityService.SigningAsync(authentificationRequestDTO.Login_name, authentificationRequestDTO.Password);

            return Ok(token);
        }
    }
    
}
