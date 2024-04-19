using BLL.Models;
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
