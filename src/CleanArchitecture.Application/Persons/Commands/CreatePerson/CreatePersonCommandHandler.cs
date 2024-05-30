using System.Xml.Linq;

using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Persons.Common;
using CleanArchitecture.Domain.Persons;

using ErrorOr;

using MediatR;

namespace CleanArchitecture.Application.Persons.Commands.CreatePerson;

public class CreatePersonCommandHandler(
    IPersonsRepository _personsRepository) : IRequestHandler<CreatePersonCommand, ErrorOr<PersonResult>>
{
    public async Task<ErrorOr<PersonResult>> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        if (await _personsRepository.GetByIdAsync(request.UserId, cancellationToken) is not null)
        {
            return Error.Conflict(description: "Person already exists");
        }

        var person = new Person(
            request.FirstName,
            request.LastName,
            request.DateOfBirth,
            request.DocumentType,
            request.DocumentNumber,
            request.Email,
            request.PhoneNumber);

        await _personsRepository.AddAsync(person, cancellationToken);

        return PersonResult.FromPerson(person);
    }
}
