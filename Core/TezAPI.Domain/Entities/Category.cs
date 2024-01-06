using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities;

public class Category: BaseEntity
{
    public string CategoryName { get; set; }
    public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    public ICollection<User> UserCategories { get; set; } = new List<User>();
}
