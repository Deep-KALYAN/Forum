using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class TopicDetail : Entity
    {

		//To work with view  public DateTime? Reply_Update_Date { get; set; }

		public bool Topic_Deleted          { get; set; }
		public int Count_Views             { get; set; }
		public int Child_Reply_Id		   { get; set; }
		public bool Child_Reply_Deleted	   { get; set; }
		public string Child_Reply_Text	   { get; set; }
		public DateTime Child_Reply_Date   { get; set; }
		public DateTime? Child_Reply_Update_Date { get; set; }
		public int Creator_Id_CR		   { get; set; }
		public string Creator_Nick_Name_CR  { get; set; }
		public int? Parent_Reply_Id		   { get; set; }
		public bool? Parent_Reply_Deleted	   { get; set; }
		public string Parent_Reply_Text	   { get; set; }
		public DateTime? Parent_Reply_Date  { get; set; }
		public DateTime? Parent_Reply_Update_Date { get; set; }
		public int? Creator_Id_PR		   { get; set; }
		public string Creator_Nick_Name_PR { get; set; }



	}
}
