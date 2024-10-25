using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorPattern.Commands;

public class UpdatePersonAgeCommandHandler(MediatrPatternDbContext dbContext) : IRequestHandler<UpdatePersonAgeCommand>
{
    public async Task Handle(UpdatePersonAgeCommand request, CancellationToken cancellationToken)
    {
        var entity = await dbContext.People.FirstAsync(p => p.Email == request.Email, cancellationToken);
        entity.Age = request.Age;

        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
