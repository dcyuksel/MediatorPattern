using MediatorPattern.Entities;
using MediatR;

namespace MediatorPattern.Queries;

public sealed record RightsQuery(string Email) : IRequest<RightEntity>;
