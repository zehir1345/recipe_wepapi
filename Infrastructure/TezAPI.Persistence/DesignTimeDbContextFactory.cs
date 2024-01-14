using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TezAPIDbContext>
{
    public TezAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<TezAPIDbContext> dbContextOptionsBuilder = new();
<<<<<<< HEAD
        dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
=======
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
        return new(dbContextOptionsBuilder.Options);
    }
}
