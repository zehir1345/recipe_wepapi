using TezAPI.Domain.Entities.Common;

namespace TezAPI.Application.Repositories
{
   public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> models);
        bool Remove(T model); 
        bool RemoveRange(List<T> datas);
        Task<bool> Remove(string id);
        bool Update(T model);
        Task<int> SaveAsync();
    }
}
