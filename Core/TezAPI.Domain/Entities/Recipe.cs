using System.ComponentModel.DataAnnotations.Schema;
using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities;
public class Recipe: BaseEntity
{
    public string RecipeName { get; set; }
    public string RecipeText { get; set; }
    public int CookingTime { get; set; }
    public int PreparationTime { get; set; }

    [ForeignKey(nameof(Writer))]
    public Guid? UserId { get; set; }
    public User? Writer { get; set; }

    [ForeignKey(nameof(Allergy))]
    public Guid? AllergyId { get; set; }
    public Allergy? Allergy { get; set; }

    public ICollection<RecipeImageFile> RecipeImageFiles { get; set; } = new List<RecipeImageFile>();
    public ICollection<Category> Categories { get; set; } = new List<Category>();
    public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<RecipeComment> Comments { get; set; } = new List<RecipeComment>();
    public ICollection<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
}
