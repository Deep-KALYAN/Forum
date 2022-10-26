using Domain.DTO.Responses.Users;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Responses.Topics
{
    public class GetTopicRepliesDetailResponseDTO 
    {
		public int			TopicId				{ get; set; }
		//public bool Topic_Deleted { get; set; }
		public int			TopicViews			{ get; set; }
		
		public int			ChildReplyId		{ get; set; }
		public bool Child_Reply_Deleted { get; set; }
		public string		ChildReplyText		{ get; set; }
		public DateTime		ChildReplyDate		{ get; set; }
		public int			CR_CreatorId		{ get; set; }
		public string		CR_CreatorNickName  { get; set; }
		public int?			ParentReplyId		{ get; set; }
		//public bool? Parent_Reply_Deleted { get; set; }
		public string		ParentReplyText		{ get; set; }
		public DateTime?	ParentReplyDate		{ get; set; }
		public int?			PR_CreatorId		{ get; set; }
		public string		PR_CreatorNickName  { get; set; }



		//public CreateUserResponseDTO ResponseUser { get; set; }
		//public byte Deleted { get; set; }
		//public int Id_Parent_Reply { get; set; }
		//public int Id_User { get; set; }
		//public int Id_Topic { get; set; }
	}
}
