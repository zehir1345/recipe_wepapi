using Microsoft.EntityFrameworkCore;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Application.Repositories
{
    public interface IRepository<T>where T: BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
