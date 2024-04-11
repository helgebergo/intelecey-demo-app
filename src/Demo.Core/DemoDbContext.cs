using Demo.Core.Abstractions;
using Demo.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Demo.Core;

public class DemoDbContext(DbContextOptions<DemoDbContext> options) : DbContext(options), IDemoDbContext
{
    public DbSet<Site> Sites => Set<Site>();
    public DbSet<Tag> Tags => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DemoDbContext).Assembly);
    }
}