using TezAPI.Application.Repositories;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class FileWriteRerpositroy : WriteRepository<TezAPI.Domain.Entities.File>, IFileWriteRepository
{
    public FileWriteRerpositroy(TezAPIDbContext context) : base(context)
    {
    }
}
