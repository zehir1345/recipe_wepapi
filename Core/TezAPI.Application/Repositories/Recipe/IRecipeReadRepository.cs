using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories
{
    public interface IRecipeReadRepository:IReadRepository<Recipe>
    {
         List<Recipe> GetFavoriteRecipes(Guid userId);
         List<Recipe> SearchRecipes(string searchLetters);
         List<Recipe> GetRecentlyViewedRecipes(Guid userId, int count);
    }
}
