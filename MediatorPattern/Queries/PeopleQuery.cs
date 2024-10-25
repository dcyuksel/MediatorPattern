using MediatorPattern.Entities;
using MediatR;

namespace MediatorPattern.Queries;

public sealed record PeopleQuery : IRequest<IReadOnlyList<PersonEntitiy>>;
