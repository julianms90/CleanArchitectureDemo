using CleanArchitecture.Domain.Persons;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persons.Persistence;

public class PersonConfigurations : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.Id)
            .ValueGeneratedNever();

        builder.Property(u => u.Email);

        builder.Property(u => u.LastName);

        builder.Property(u => u.FirstName);

        builder.Property(u => u.DateOfBirth);

        builder.Property(u => u.DocumentType);

        builder.Property(u => u.DocumentNumber);

        builder.Property(u => u.PhoneNumber);

        builder.Property(u => u.AddressId);

        builder.Property(u => u.UserId);

        builder.HasOne(t => t.Address).WithOne(p => p.Person)
            .HasForeignKey<Person>(q => q.AddressId);

        builder.HasOne(t => t.User).WithOne(p => p.Person)
            .HasForeignKey<Person>(q => q.UserId);
    }
}