using MediatorPattern.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorPattern.Queries;

public class PersonQueryByEmailHandler(MediatrPatternDbContext dbContext) : IRequestHandler<PersonQueryByEmail, PersonEntitiy>
{
    public async Task<PersonEntitiy> Handle(PersonQueryByEmail request, CancellationToken cancellationToken)
    {
        return await dbContext.People.FirstAsync(p=> p.Email == request.Email, cancellationToken);
    }
}
