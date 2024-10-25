using MediatR;

namespace MediatorPattern.Notifications;

public class AddLogWhenAgeIsChangedNotificationHandler(ILogger<AddLogWhenAgeIsChangedNotificationHandler> logger) : INotificationHandler<AgeChangedNotification>
{
    public Task Handle(AgeChangedNotification notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Age is updated. Email: {Email}.", notification.Email);

        return Task.CompletedTask;
    }
}
