using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class RecipeımageFileReadRepository : ReadRepository<TezAPI.Domain.Entities.RecipeImageFile>, IRecipeImageFileReadRepository
{
    private readonly TezAPIDbContext _context;

    public RecipeımageFileReadRepository(TezAPIDbContext context) : base(context)
    {
        _context = context;
    }

    public List<RecipeImageFile> GetRecipeImages(Guid recipeId)
    {
        var recipe = _context.Set<Recipe>().Find(recipeId);

        if (recipe == null)
        {
            // Handle the case where the recipe is not found
            return new List<RecipeImageFile>(); // veya null dönebilirsiniz, bu sizin tasarımınıza bağlı
        }

        // Tarife ait resim dosyalarını getir
        var recipeImages = recipe.RecipeImageFiles.ToList();

        return recipeImages;
    }

}
