using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivite3.DomainWF.BOWF
{
    public class BOReply
    {
		public string ChildReplyText { get; set; }
		public string CR_CreatorNickName { get; set; }
		//public bool Topic_Deleted { get; set; }
		public DateTime ChildReplyDate { get; set; }
		public string ParentReplyText { get; set; }
		public string PR_CreatorNickName { get; set; }
		public DateTime? ParentReplyDate { get; set; }

		public int ChildReplyId { get; set; }
		public int CR_CreatorId { get; set; }
		public int? ParentReplyId { get; set; }
		public int? PR_CreatorId { get; set; }
		//public bool? Parent_Reply_Deleted { get; set; }
		public int TopicId { get; set; }
		public bool Child_Reply_Deleted { get; set; }
		public int TopicViews { get; set; }
	}
}
