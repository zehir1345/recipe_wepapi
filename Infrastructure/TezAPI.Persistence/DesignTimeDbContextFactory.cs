using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TezAPIDbContext>
{
    public TezAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<TezAPIDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}
