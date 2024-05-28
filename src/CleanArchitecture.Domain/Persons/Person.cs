using CleanArchitecture.Domain.Addresses;
using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Users;

namespace CleanArchitecture.Domain.Persons
{
    public class Person : Entity
    {
        public string FirstName { get; } = null!;
        public string LastName { get; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string DocumentType { get; } = null!;
        public string DocumentNumber { get; } = null!;
        public string Email { get; } = null!;
        public string PhoneNumber { get; } = null!;
        public string AddressId { get; } = null!;
        public string UserId { get; } = null!;
        public virtual Address Address { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public Person(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string documentType,
            string documentNumber,
            string email,
            string phoneNumber,
            Address address,
            User user)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            DocumentNumber = documentNumber;
            DocumentType = documentType;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            User = user;
        }

        public Person() { }
    }
}
