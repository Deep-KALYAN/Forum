using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Requestes.Topics
{
    public class CreateTopicRequestDTO
    {

        
        public string TopicTitle { get; set; }
        public string TopicText { get; set; }
        public int TopicRubricId{ get; set; }
       // public DateTime TopicPulishedDate { get; set; }
        //public byte TopicDeleted { get; set; }
        //public int TopicCreatorId { get; set; }
        //public int TopicViews { get; set; }

    }
    public class CreateTopicRequestDTOValidator : AbstractValidator<CreateTopicRequestDTO>
    {
        public CreateTopicRequestDTOValidator()
        {
            RuleFor(x => x.TopicTitle).NotEmpty().NotNull().MinimumLength(3).MaximumLength(500);
            RuleFor(x => x.TopicText).NotNull().NotEmpty().MinimumLength(3).MaximumLength(500);
            RuleFor(x => x.TopicRubricId).NotNull().NotEmpty();
        }
    }

}
