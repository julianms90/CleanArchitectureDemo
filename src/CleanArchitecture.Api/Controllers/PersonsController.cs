using CleanArchitecture.Application.Persons.Commands.CreatePerson;
using CleanArchitecture.Application.Persons.Common;
using CleanArchitecture.Application.Persons.Queries.GetPerson;
using CleanArchitecture.Contracts.Persons;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[Route("Persons")]
public class PersonsController(IMediator _mediator) : ApiController
{
    [HttpPost]
    public async Task<IActionResult> CreatePerson(Guid id, CreatePersonRequest request)
    {
        var command = new CreatePersonCommand(
            id,
            request.FirstName,
            request.LastName,
            request.DateOfBirth,
            request.DocumentType,
            request.DocumentNumber,
            request.Email,
            request.PhoneNumber);

        var result = await _mediator.Send(command);

        return result.Match(
            Person => CreatedAtAction(
                actionName: nameof(GetPerson),
                routeValues: new { UserId = id },
                value: ToDto(Person)),
            Problem);
    }

    [HttpGet]
    public async Task<IActionResult> GetPerson(Guid id)
    {
        var query = new GetPersonQuery(id);

        var result = await _mediator.Send(query);

        return result.Match(
            person => Ok(ToDtoGet(person)),
            Problem);
    }

    private static PersonResponse ToDto(PersonResult PersonResult) =>
        new(PersonResult.Id);

    private static PersonResponseGet ToDtoGet(PersonResult PersonResult) =>
    new(
        PersonResult.Id,
        PersonResult.FirstName);
}