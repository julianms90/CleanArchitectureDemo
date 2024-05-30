using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Persons.Common;
using CleanArchitecture.Domain.Persons;

using ErrorOr;

using MediatR;

namespace CleanArchitecture.Application.Persons.Queries.GetPerson;

public class GetPersonQueryHandler(IPersonsRepository _personsRepository)
    : IRequestHandler<GetPersonQuery, ErrorOr<PersonResult>>
{
    public async Task<ErrorOr<PersonResult>> Handle(GetPersonQuery request, CancellationToken cancellationToken)
    {
        return await _personsRepository.GetByIdAsync(request.UserId, cancellationToken) is Person person
            ? PersonResult.FromPerson(person)
            : Error.NotFound(description: "Person not found.");
    }
}
