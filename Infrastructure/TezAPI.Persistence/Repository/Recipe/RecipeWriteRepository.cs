using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class RecipeWriteRepository : WriteRepository<Recipe>, IRecipeWriteRepository
    {
        public RecipeWriteRepository(TezAPIDbContext context) : base(context)
        {
        }

        public void UpdateFavState(Recipe recipe)
        {
          
        }
    }
}
