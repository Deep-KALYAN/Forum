using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Responses.Users
{
    public class GetUserByIdResponseDTO
    {
        public string Name { get; set; }
        public string First_Name { get; set; }
        public string Login_Name { get; set; }
        public string Ph_No { get; set; }
        public Byte[] Photo { get; set; }
        public string E_Mail { get; set; }
        //public string Password { get; set; }
        public int Id { get; set; }
    }
}
