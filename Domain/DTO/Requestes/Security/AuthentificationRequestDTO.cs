using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Requestes.Security
{
    public class AuthentificationRequestDTO
    {
        public string Login_name { get; set; }

        public string Password { get; set; }
    }

    public class AuthentificationRequestDTOValidator : AbstractValidator<AuthentificationRequestDTO>
    {
        public AuthentificationRequestDTOValidator()
        {
            RuleFor(x => x.Login_name).NotNull().NotEmpty();
            RuleFor(x => x.Password).NotNull().NotEmpty();

        }
    }
}
