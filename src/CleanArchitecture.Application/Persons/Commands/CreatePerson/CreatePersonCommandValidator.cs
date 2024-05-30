using FluentValidation;

namespace CleanArchitecture.Application.Persons.Commands.CreatePerson;

public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
{
    public CreatePersonCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .MinimumLength(2)
            .MaximumLength(10000);

        RuleFor(x => x.LastName)
            .MinimumLength(2)
            .MaximumLength(10000);

        RuleFor(x => x.Email).EmailAddress();
    }
}