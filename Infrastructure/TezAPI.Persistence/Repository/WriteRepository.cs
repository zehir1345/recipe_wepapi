using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities.Common;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly TezAPIDbContext _context;
    public WriteRepository(TezAPIDbContext context)
    {
        _context = context;
    }
    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> models)
    {
       await Table.AddRangeAsync(models);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);
        return entityEntry.State == EntityState.Deleted;
    }

    

    public async Task<bool> Remove(string id)
    {
       T model= await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        return Remove(model);
    }

    public bool RemoveRange(List<T> datas)
    {
        Table.RemoveRange(datas);
        return true;
    }

    public async Task<int> SaveAsync()
    => await _context.SaveChangesAsync();

    public bool Update(T model)
    {
        EntityEntry<T> entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }
   
}
