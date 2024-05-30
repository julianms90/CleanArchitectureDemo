using CleanArchitecture.Application.Common.Security.Permissions;
using CleanArchitecture.Application.Common.Security.Request;
using CleanArchitecture.Application.Persons.Common;

using ErrorOr;

namespace CleanArchitecture.Application.Persons.Queries.GetPerson;

[Authorize(Permissions = Permission.Person.Get)]
public record GetPersonQuery(Guid UserId)
    : IAuthorizeableRequest<ErrorOr<PersonResult>>;