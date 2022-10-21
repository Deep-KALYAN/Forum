using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Requestes.Replies
{
    public class CreateReplyRequestDTO
    {
        public int UserId { get; set; }
        public string   ReplyText       {get; set;}
         public int?      ReplyParentId   {get; set;}
         public int      ReplyTopicId    {get; set;}

        
    }
    public class CreateReplyRequestDTOValidator : AbstractValidator<CreateReplyRequestDTO>
    {
        public CreateReplyRequestDTOValidator()
        {
            RuleFor(x => x.ReplyText).NotEmpty().NotNull().MinimumLength(3).MaximumLength(500);
            RuleFor(x => x.ReplyTopicId).NotNull().NotEmpty();
        }
    }
    }
