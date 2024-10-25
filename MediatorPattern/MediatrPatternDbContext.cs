using MediatorPattern.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatorPattern;

public class MediatrPatternDbContext(DbContextOptions<MediatrPatternDbContext> options) : DbContext(options)
{
    public virtual DbSet<PersonEntitiy> People { get; set; }
    public virtual DbSet<RightEntity> Rights { get; set; }
}
