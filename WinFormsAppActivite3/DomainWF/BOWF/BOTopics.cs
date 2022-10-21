using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppActivite3.DomainWF.BOWF
{
    public class BOTopics
    {
		public string TopicTitle { get; set; }
		public string TopicText { get; set; }
		public string TopicCreatorNickName { get; set; }
		public DateTime? TopicPublishedDate { get; set; }
		public int RubricId { get; set; }
		public string RubricName { get; set; }
		public int? TopicId { get; set; }

	}
}
