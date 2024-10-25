using MediatorPattern.Entities;
using MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPattern;

[Route("rights")]
public class RightsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    [Route("by-email")]
    public async Task<RightEntity> GetRightsByEmail(string email)
    {
        return await mediator.Send(new RightsQuery(email));
    }
}
