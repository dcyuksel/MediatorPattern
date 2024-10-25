using MediatorPattern.Commands;
using MediatorPattern.Entities;
using MediatorPattern.Notifications;
using MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPattern;

[Route("people")]
public class PeopleController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public async Task<IReadOnlyList<PersonEntitiy>> GetPeople()
    {
        return await mediator.Send(new PeopleQuery());  
    }

    [HttpGet]
    [Route("by-email")]
    public async Task<PersonEntitiy> GetPersonByEmail(string email)
    {
        return await mediator.Send(new PersonQueryByEmail(email));
    }

    [HttpGet]
    [Route("update-age")]
    public async Task UpdateAge(string email, int age)
    {
        await mediator.Send(new UpdatePersonAgeCommand(email, age));
        await mediator.Publish(new AgeChangedNotification(email));
    }
}
