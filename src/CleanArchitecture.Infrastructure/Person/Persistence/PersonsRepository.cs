using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Persons;
using CleanArchitecture.Infrastructure.Common;

namespace CleanArchitecture.Infrastructure.Persons.Persistence;

public class PersonsRepository : IPersonsRepository
{
    private readonly AppDbContext _dbContext;

    public PersonsRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(Person Person, CancellationToken cancellationToken)
    {
        await _dbContext.AddAsync(Person, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Person?> GetByIdAsync(Guid PersonId, CancellationToken cancellationToken)
    {
        return await _dbContext.Persons.FindAsync(PersonId, cancellationToken);
    }

    public async Task RemoveAsync(Person Person, CancellationToken cancellationToken)
    {
        _dbContext.Remove(Person);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(Person Person, CancellationToken cancellationToken)
    {
        _dbContext.Update(Person);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}