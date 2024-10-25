using MediatR;

namespace MediatorPattern.Notifications;

public sealed record AgeChangedNotification(string Email) : INotification;