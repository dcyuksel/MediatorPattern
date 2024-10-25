using MediatorPattern.Entities;
using MediatR;

namespace MediatorPattern.Queries;

public sealed record class PersonQueryByEmail(string Email) : IRequest<PersonEntitiy>;