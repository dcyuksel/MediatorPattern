using MediatorPattern.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorPattern.Queries;

public class RightsQueryHandler(MediatrPatternDbContext dbContext) : IRequestHandler<RightsQuery, RightEntity>
{
    public async Task<RightEntity> Handle(RightsQuery request, CancellationToken cancellationToken)
    {
        return await dbContext.Rights.FirstAsync(r => r.Email == request.Email, cancellationToken);
    }
}
