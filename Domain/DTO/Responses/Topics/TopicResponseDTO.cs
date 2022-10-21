using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Responses.Topics
{
    public class TopicResponseDTO
    {
        public int       TopicId             { get; set; }
        public string       TopicTitle          { get; set; }
        public string    TopicText           { get; set; }
        public DateTime TopicPublishedDate  { get; set; }
     //   public int     TopicIdUser { get; set; }
        public int TopicCreatorId { get; set; }
        public int       TopicIdRubric      { get; set; }

        public int      TopicCountViews      { get; set; }
    }
}
