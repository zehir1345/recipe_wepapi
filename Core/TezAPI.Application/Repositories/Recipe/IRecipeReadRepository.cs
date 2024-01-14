using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories
{
    public interface IRecipeReadRepository:IReadRepository<Recipe>
    {
<<<<<<< HEAD
         List<Recipe> GetFavoriteRecipes(Guid userId);
         List<Recipe> SearchRecipes(string searchLetters);
         List<Recipe> GetRecentlyViewedRecipes(Guid userId, int count);
=======
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
    }
}
