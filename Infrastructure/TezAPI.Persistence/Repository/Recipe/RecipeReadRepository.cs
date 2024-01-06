using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class RecipeReadRepository : ReadRepository<Recipe>, IRecipeReadRepository
    {
        public RecipeReadRepository(TezAPIDbContext context) : base(context)
        {
        }
    }
}
