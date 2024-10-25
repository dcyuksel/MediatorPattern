using MediatR;

namespace MediatorPattern.Commands;

public sealed record UpdatePersonAgeCommand(string Email, int Age) : IRequest;