using TezAPI.Application.Repositories;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class RecipeımageFileReadRepository : ReadRepository<TezAPI.Domain.Entities.RecipeImageFile>, IRecipeImageFileReadRepository
{
    public RecipeımageFileReadRepository(TezAPIDbContext context) : base(context)
    {
    }
}
