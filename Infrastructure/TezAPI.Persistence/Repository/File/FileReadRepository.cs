using TezAPI.Application.Repositories;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class FileReadRepository : ReadRepository<TezAPI.Domain.Entities.File>, IFileReadRepository
{
    public FileReadRepository(TezAPIDbContext context) : base(context)
    {
    }
}
