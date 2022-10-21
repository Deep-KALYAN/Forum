using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Requestes.Replies
{
    public class UpdateReplyRequestDTO
    {
        public string ReplyText { get; set; }
        public int    ReplyId { get; set; }
       
        public int IdUser { get; set; }


    }
    public class UpdateReplyRequestDTOValidator : AbstractValidator<UpdateReplyRequestDTO>
    {
        public UpdateReplyRequestDTOValidator()
        {
            RuleFor(x => x.ReplyText).NotEmpty().NotNull().MaximumLength(3).MaximumLength(500);
            RuleFor(x => x.ReplyId).NotNull().NotEmpty();
        }
    }
}
