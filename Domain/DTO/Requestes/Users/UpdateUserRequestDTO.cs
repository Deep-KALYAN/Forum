using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Requestes.Users
{
    public class UpdateUserRequestDTO
    {
        public string Name          { get; set; }
        public string First_Name    { get; set; }
        public string Login_Name    { get; set; }
        public string Ph_No         { get; set; }
      //  public Byte[] Photo { get; set; }
        public string E_Mail        { get; set; }
        public string Password      { get; set; }
        public int    Id            { get; set; }
    }
    public class UpdateUserRequestDTOValidator : AbstractValidator<UpdateUserRequestDTO>
    {
        public UpdateUserRequestDTOValidator()
        {
            RuleFor(x => x.First_Name).NotEmpty().NotNull().MaximumLength(30);
            RuleFor(x => x.Name).NotEmpty().NotNull().MaximumLength(30);
            RuleFor(x => x.Login_Name).NotEmpty().NotNull().MaximumLength(30);
            RuleFor(x => x.Ph_No).NotEmpty().NotNull().MaximumLength(10);
         //   RuleFor(x => x.Photo);
            RuleFor(x => x.E_Mail).NotEmpty().NotNull().MaximumLength(60).EmailAddress(EmailValidationMode.AspNetCoreCompatible);
            RuleFor(x => x.Password).NotEmpty().NotNull().MaximumLength(50).MinimumLength(5);
        }
    }
}
