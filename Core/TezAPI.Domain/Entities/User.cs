using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities;
public class User: BaseEntity
{
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    public ICollection<Recipe> FavoriteRecipes { get; set; } = new List<Recipe>();
    public ICollection<Category> UserFavoriteCategories { get; set; } = new List<Category>();
    public ICollection<Allergy> Allergies { get; set; } = new List<Allergy>();
    public ICollection<RecipeComment> Comments { get; set; } = new List<RecipeComment>();
}
