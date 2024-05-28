using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Persons;

namespace CleanArchitecture.Domain.Addresses
{
    public class Address : Entity
    {
        public Address(
            string street,
            string number,
            string apartment,
            string zipCode,
            string city,
            string province,
            string country)
        {
            Street = street;
            Number = number;
            Apartment = apartment;
            ZipCode = zipCode;
            City = city;
            Province = province;
            Country = country;
        }

        public string Street { get; } = null!;
        public string Number { get; } = null!;
        public string Apartment { get; } = null!;
        public string ZipCode { get; } = null!;
        public string City { get; } = null!;
        public string Province { get; } = null!;
        public string Country { get; } = null!;
        public virtual Person Person { get; } = new Person();
        private Address() { }
    }
}