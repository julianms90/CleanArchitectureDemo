using CleanArchitecture.Domain.Addresses;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Users;

namespace CleanArchitecture.Domain.Persons
{
    public class Person : Entity
    {
        public Person(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string documentType,
            string documentNumber,
            string email,
            string phoneNumber,
            Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            DocumentNumber = documentNumber;
            DocumentType = documentType;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        private Person() { }

        public Guid AddressId { get; set; }
        public string FirstName { get; } = null!;
        public string LastName { get; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string DocumentType { get; } = null!;
        public string DocumentNumber { get; } = null!;
        public string Email { get; } = null!;
        public string PhoneNumber { get; } = null!;
        public string UserId { get; } = null!;
        public Address Address { get; private set; } = null!;
    }
}
