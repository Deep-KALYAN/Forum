using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Responses.Users
{
    public class GetUsersResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }     //_
        public string LoginName { get; set; } //_
        public string PhNo { get; set; } //_
    //    public Byte[] Photo { get; set; }
        public string EMail { get; set; } //_

        public bool ModeratorYN { get; set; } //_  _
        public string Password { get; set; }
    }
}
