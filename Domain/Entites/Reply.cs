using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Reply : Entity
    {
       // public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Reply_Date { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? Reply_Update_Date { get; set; }
        public int? Id_Parent_Reply { get; set; }
        public int Id_User { get; set; }
        public int? Id_Topic { get; set; }

        //public override bool Equals(object obj)
        //{
        //    return obj is Reply reply &&
        //           base.Equals(obj) &&
        //           Id == reply.Id &&
        //           Text == reply.Text &&
        //           Reply_Date == reply.Reply_Date &&
        //           //Deleted == reply.Deleted &&
        //           Id_Parent_Reply == reply.Id_Parent_Reply &&
        //           Id_User == reply.Id_User &&
        //           Id_Topic == reply.Id_Topic;
        //}

        // public Reply replyParent { get; set; }
    }
}
