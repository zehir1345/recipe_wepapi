using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities;

public class Ingredient: BaseEntity
{
    public string IngredientName { get; set; }
    public ICollection<RecipeIngredient> Recipes { get; set; } = new List<RecipeIngredient>();

}
