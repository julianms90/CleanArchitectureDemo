using CleanArchitecture.Domain.Persons;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persons.Persistence;

public class PersonConfigurations : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.Property(u => u.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWSEQUENTIALID()");

        builder.Property<string?>(u => u.Email);

        builder.Property<string?>(u => u.LastName);

        builder.Property<string?>(u => u.FirstName);

        builder.Property(u => u.DateOfBirth);

        builder.Property<string?>(u => u.DocumentType);

        builder.Property<string?>(u => u.DocumentNumber);

        builder.Property<string?>(u => u.PhoneNumber);

        // builder.Property<Guid?>(u => u.AddressId);
        // builder.HasOne(t => t.Address).WithOne(p => p.Person)
        // .HasForeignKey<Person>(q => q.AddressId);
    }
}