using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorPattern.Notifications;

public class UpdateRightsWhenAgeIsChangedNotificationHandler(MediatrPatternDbContext dbContext) : INotificationHandler<AgeChangedNotification>
{
    public async Task Handle(AgeChangedNotification notification, CancellationToken cancellationToken)
    {
        var person = await dbContext.People.FirstAsync(p => p.Email == notification.Email, cancellationToken);
        var rights = await dbContext.Rights.FirstAsync(p => p.Email == notification.Email, cancellationToken);
        if (person.Age > 16)
        {
            rights.DriverLicence = true;
        }
        else 
        {
            rights.DriverLicence = false;
        }

        if (person.Age > 18)
        {
            rights.Vote = true;
        }
        else
        {
            rights.Vote = false;
        }

        if (person.Age > 21)
        {
            rights.DrinkAlcohol = true;
        }
        else
        {
            rights.DrinkAlcohol = false;
        }

        await dbContext.SaveChangesAsync();
    }
}
