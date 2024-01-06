using System.Linq.Expressions;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T: BaseEntity
    {

        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);  
        Task<T> GetByIdAsync(string id);
    } 
}
