using CleanArchitecture.Domain.Persons;

using Throw;

namespace CleanArchitecture.Application.Persons.Common;

public record PersonResult(Guid Id, string FirstName)
{
    public static PersonResult FromPerson(Person person)
    {
        return new PersonResult(person.Id, person.FirstName);
    }
}