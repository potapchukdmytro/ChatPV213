using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Client.Validation
{
    public class LogInModelValidation : AbstractValidator<LogInModel>
    {
        public LogInModelValidation()
        {
            RuleFor(x => x.Login).NotEmpty().WithMessage("Обов'язкове поле");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Необхідно ввести пароль.").MinimumLength(8).WithMessage("Мінімальна довжина 8 символів");
        }
    }
}
