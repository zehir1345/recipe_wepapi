using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities.Common;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly TezAPIDbContext _context;
    public ReadRepository(TezAPIDbContext context)
    {
        _context = context;
    }
    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll()
      => Table;

    public async Task<T> GetByIdAsync(string id)
   => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
    => await Table.FirstOrDefaultAsync(method);

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);
    
}
