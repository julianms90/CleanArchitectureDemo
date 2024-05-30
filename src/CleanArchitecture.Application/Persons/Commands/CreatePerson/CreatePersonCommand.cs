using CleanArchitecture.Application.Common.Security.Permissions;
using CleanArchitecture.Application.Common.Security.Request;
using CleanArchitecture.Application.Persons.Common;

using ErrorOr;

namespace CleanArchitecture.Application.Persons.Commands.CreatePerson;

[Authorize(Permissions = Permission.Person.Create)]
public record CreatePersonCommand(
            Guid UserId,
            string FirstName,
            string LastName,
            DateTime DateOfBirth,
            string DocumentType,
            string DocumentNumber,
            string Email,
            string PhoneNumber)
    : IAuthorizeableRequest<ErrorOr<PersonResult>>;