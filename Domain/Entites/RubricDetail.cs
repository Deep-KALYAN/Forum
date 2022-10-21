using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class RubricDetail : Entity
    {
		//To work with view
		
		public  string      Rubric_Name         { get; set; } 
		public  int?         Topic_Id            { get; set; }
		public  bool?        Topic_Deleted        { get; set; }
		public  string     Topic_Tex_Pub       { get; set; }
		public  DateTime?    Topic_Pub_Date      { get; set; }
		public DateTime? Topic_Pub_Update_Date { get; set; }
		public  string      Topic_Title         { get; set; }
		public  int?         T_Creator_Id        { get; set; }
		public  string      T_Creator_Nick_Name { get; set; }


	}
}
