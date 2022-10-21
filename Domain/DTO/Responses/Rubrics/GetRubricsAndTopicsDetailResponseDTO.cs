using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Responses.Rubrics
{
    public class GetRubricsAndTopicsDetailResponseDTO
    {
		public int RubricId { get; set; }
		public string RubricName { get; set; }
		
		public int? TopicId { get; set; }		
		public string TopicText { get; set; }
		public DateTime? TopicPublishedDate { get; set; }
		public string TopicTitle { get; set; }
		public string TopicCreatorNickName { get; set; }
	}


}
