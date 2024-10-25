using MediatorPattern.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorPattern.Queries;

public class PeopleQueryHandler(MediatrPatternDbContext dbContext) : IRequestHandler<PeopleQuery, IReadOnlyList<PersonEntitiy>>
{
    public async Task<IReadOnlyList<PersonEntitiy>> Handle(PeopleQuery request, CancellationToken cancellationToken)
    {
        return await dbContext.People.ToListAsync(cancellationToken);
    }
}
