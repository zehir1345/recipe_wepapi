using TezAPI.Domain.Entities;

namespace TezAPI.Application.ViewModel.Recipes
{
    public class VM_Create_Recipe
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UserId { get; set; }
        public string RecipeText { get; set; }
        public bool IsItFavorite { get; set; }
        public int CookingTime { get; set; }
        public int PreparationTime { get; set; }
        public User Writer { get; set; }
    }
}
