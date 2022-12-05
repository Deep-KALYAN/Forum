using DAL.UOW;
using Domain.Entites;
using Domain.Exceptions;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class SecurityService : ISecurityService
    {
        private readonly IConfiguration _configuration;

        private readonly IAccountService _accountService;
        public SecurityService(IConfiguration configuration, IAccountService accountService)   //, IAccountService accountService
        {
            _configuration = configuration;
            _accountService = accountService;
        }

        #region Security
        //+Signing(string : login_name, parameter : password)

       

            public async Task<string> SigningAsync(string login_name, string password)
        {
            /*have verify here the real user*/

            var user = await _accountService.GetUserByloginNameAsync(login_name);  //  GetUserBylogin_NameAsync(login_name);

            if (user == null) throw new ForbiddenAccessException();

            bool Moderator_Y_N = user.Moderator_Y_N; //user.Moderator_Y_N;
            string nick_name = user.Nick_Name;
            string user_password = user.Password;
            string id = user.Id.ToString();
            
            string user_enc_password = AccountService.Encrypt(password);



            // Si l'utilisateur existe ou non
            if (login_name == nick_name && user_enc_password == user_password && Moderator_Y_N == true) //? Moderator or not  //"admin"
            {
                return GenerateJwtToken(login_name, new List<string>() { "ADMIN", "USER" }, id);       //, id
            }
            // Généré le token avec les bons roles
            else if (login_name == nick_name && user_enc_password == user_password && Moderator_Y_N == false)
            {
                return GenerateJwtToken(login_name, new List<string>() { "USER" }, id);               //, id
            }

            // AuthentificationFailException
            throw new AuthentificationFailException();

        }

        private string GenerateJwtToken(string login_name, List<string> roles, string id)
        {
            //Add User Infos
            var claims = new List<Claim>(){
               new Claim(JwtRegisteredClaimNames.Sub, login_name),
               new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
               new Claim(ClaimTypes.NameIdentifier, id)
             //  new Claim("NewClaim", "toto"),

           };

            //Add Roles
            roles.ForEach(role =>
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            });

            //Signing Key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Expiration time
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

            //Create JWT Token Object
            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudiences"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            //Serializes a JwtSecurityToken into a JWT in Compact Serialization Format.
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        #endregion
    }
}
