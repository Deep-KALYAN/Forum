using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Responses.Replies
{
    public class ReplyResponseDTO
    {

        public int? ReplyId { get; set; }
        public string ReplyText { get; set; }
        public DateTime? ReplyDate { get; set; }
        public int? ParentReplyId { get; set; }
        public int? CreatorId { get; set; }
        public int? TopicId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ReplyResponseDTO dTO &&
                   ReplyId == dTO.ReplyId &&
                   ReplyText == dTO.ReplyText &&
                   ReplyDate == dTO.ReplyDate

            //       &&
            //ParentReplyId == null &&
            //CreatorId == null &&
            //TopicId == null;

            &&
            ParentReplyId == dTO.ParentReplyId &&
            CreatorId == dTO.CreatorId &&
            TopicId == dTO.TopicId;
        }
    }

}
