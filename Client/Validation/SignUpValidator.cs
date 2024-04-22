using Client.Models;
using FluentValidation;

namespace Client.Validation
{
    public class SignUpValidator : AbstractValidator<SignUpModel>
    {
        public SignUpValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ім'я не повино бути порожнім");
            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Призвіще не повино бути порожнім");
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Username).NotEmpty().MinimumLength(4);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
        }
    }
}
