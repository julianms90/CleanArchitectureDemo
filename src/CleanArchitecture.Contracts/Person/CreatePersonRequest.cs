namespace CleanArchitecture.Contracts.Persons;

public record CreatePersonRequest(
            string FirstName,
            string LastName,
            DateTime DateOfBirth,
            string DocumentType,
            string DocumentNumber,
            string Email,
            string PhoneNumber);
