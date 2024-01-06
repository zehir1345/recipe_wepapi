using TezAPI.Application.Repositories;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;
public class RecipeImageWriteRepository : WriteRepository<TezAPI.Domain.Entities.RecipeImageFile>, IRecipeImageFileWriteRepository
{
    public RecipeImageWriteRepository(TezAPIDbContext context) : base(context)
    {
    }
}
