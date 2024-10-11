using FastEndApp.API.Contracts.Requests;
using FastEndpoints;
using FluentValidation;

namespace FastEndApp.API.Validators;

public class UserRequestValidator:Validator<UserRequest>
{
    public UserRequestValidator()
    {
        RuleFor(u => u.FirstName)
            .NotEmpty().WithMessage("Name can not be empty")
            .MinimumLength(2).WithMessage("Minimum 2 characters");
        RuleFor(u => u.LastName)
            .NotEmpty().WithMessage("LastName can not be empty")
            .MinimumLength(2).WithMessage("Minimum 2 characters");
        RuleFor(u => u.Age)
            .NotEmpty().WithMessage("Age can't be empty")
            .GreaterThan(16).WithMessage("Only great 16 year");
    }
}
