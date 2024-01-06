namespace TezAPI.Domain.Entities;
public class RecipeImageFile : File
{
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
