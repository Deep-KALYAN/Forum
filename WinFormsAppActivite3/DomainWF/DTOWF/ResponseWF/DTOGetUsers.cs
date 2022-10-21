using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivite3.DomainWF.DTOWF.ResponseWF
{
    public class DTOGetUsers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string First_Name { get; set; }
        public string Login_Name { get; set; }
        public string Ph_No { get; set; }
 //       public Byte[] Photo { get; set; }
        public string E_Mail { get; set; }

        public bool Moderator_Y_N { get; set; }
        public string Password { get; set; }
     
    }
}
