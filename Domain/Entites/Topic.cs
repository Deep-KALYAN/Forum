using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Topic : Entity
    {
      //  public int Id { get; set; }
        public string Title { get; set; }
        public string Text_Pub { get; set; }
        public DateTime Pub_Date { get; set; }
        public byte Deleted { get; set; }
        public DateTime? Pub_Update_Date { get; set; }
        public int Id_User { get; set; }
        public int Id_Rubric { get; set; }

        public int Count_Views { get; set; }
    }
}
