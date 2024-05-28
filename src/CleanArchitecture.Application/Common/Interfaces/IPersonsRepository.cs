using CleanArchitecture.Domain.Persons;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IPersonsRepository
{
    Task AddAsync(Person Person, CancellationToken cancellationToken);
    Task<Person?> GetByIdAsync(Guid PersonId, CancellationToken cancellationToken);
    Task RemoveAsync(Person Person, CancellationToken cancellationToken);
    Task UpdateAsync(Person Person, CancellationToken cancellationToken);
}