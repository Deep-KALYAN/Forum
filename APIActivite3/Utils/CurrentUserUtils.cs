using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace APIActivite3.Utils
{
    public class CurrentUserUtils : ICurrentUserUtils
    {
        private readonly IHttpContextAccessor _httpContextAcessor;
        public CurrentUserUtils(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAcessor = httpContextAccessor;
        }

        public int? GetCurrentUserId()
        {
            var strId = _httpContextAcessor.HttpContext.User.Claims.ElementAt(2).Value;
            //_httpContextAcessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

            if (strId is not null)
            {
                return int.Parse(strId);
            }
            else
            {
                return null;
            }
        }

        public bool IsModerator()
        {
          //  var strId = _httpContextAcessor.HttpContext. User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value;

            return false;
        }
    }
}
