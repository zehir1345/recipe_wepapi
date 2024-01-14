using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities;
public class User: BaseEntity
{
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    public ICollection<Recipe> FavoriteRecipes { get; set; } = new List<Recipe>();
    public ICollection<Category> UserFavoriteCategories { get; set; } = new List<Category>();
<<<<<<< HEAD
    public ICollection<Allergy> Allergies { get; set; } = new List<Allergy>();
=======
    public ICollection<Allergy> UserAllergies { get; set; } = new List<Allergy>();
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
    public ICollection<RecipeComment> Comments { get; set; } = new List<RecipeComment>();
}
