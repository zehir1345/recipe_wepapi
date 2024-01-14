using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories
{
    public interface IRecipeWriteRepository:IWriteRepository<Recipe>
    {
         Task AddToFavoritesAsync(Guid userId, Guid recipeId);
         Task RemoveFromFavoritesAsync(Guid userId, Guid recipeId);
        void UpdateFavState(Recipe recipe);
        // void, eğer field true ise r favr tır
    }
}
