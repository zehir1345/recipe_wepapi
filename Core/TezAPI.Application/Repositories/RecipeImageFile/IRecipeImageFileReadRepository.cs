using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories;
public interface IRecipeImageFileReadRepository : IReadRepository<TezAPI.Domain.Entities.RecipeImageFile>
{
    List<RecipeImageFile> GetRecipeImages(Guid recipeId);
}