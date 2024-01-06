using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories
{
    public interface IRecipeWriteRepository:IWriteRepository<Recipe>
    {
        void UpdateFavState(Recipe recipe);
        // void, eğer field true ise r favr tır
    }
}
