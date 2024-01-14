using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories
{
    public interface IRecipeWriteRepository:IWriteRepository<Recipe>
    {
<<<<<<< HEAD
         Task AddToFavoritesAsync(Guid userId, Guid recipeId);
         Task RemoveFromFavoritesAsync(Guid userId, Guid recipeId);
=======
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
        void UpdateFavState(Recipe recipe);
        // void, eğer field true ise r favr tır
    }
}
