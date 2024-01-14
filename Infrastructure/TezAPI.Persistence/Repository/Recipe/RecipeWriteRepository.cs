using Microsoft.EntityFrameworkCore;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class RecipeWriteRepository : WriteRepository<Recipe>, IRecipeWriteRepository
    {
        private readonly TezAPIDbContext context;
        public RecipeWriteRepository(TezAPIDbContext context) : base(context)
        {
            context = context;
        }
        public async Task AddToFavoritesAsync(Guid userId, Guid recipeId)
        {
            var user = await context.Set<User>().FindAsync(userId);

            if (user == null)
            {
                // Handle the case where the user is not found
                return;
            }

            var recipe = await context.Set<Recipe>().FindAsync(recipeId);

            if (recipe == null)
            {
                // Handle the case where the recipe is not found
                return;
            }

            // Check if the recipe is already in the user's favorites
            if (user.FavoriteRecipes.Contains(recipe))
            {
                // Handle the case where the recipe is already in favorites
                return;
            }

            // Add the recipe to the user's favorites
            user.FavoriteRecipes.Add(recipe);
            await context.SaveChangesAsync();
        }
        public async Task RemoveFromFavoritesAsync(Guid userId, Guid recipeId)
        {
            var user = await context.Set<User>().FindAsync(userId);

            if (user == null)
            {
                // Handle the case where the user is not found
                return;
            }

            var recipe = await context.Set<Recipe>().FindAsync(recipeId);

            if (recipe == null)
            {
                // Handle the case where the recipe is not found
                return;
            }

            // Check if the recipe is in the user's favorites
            if (!user.FavoriteRecipes.Contains(recipe))
            {
                // Handle the case where the recipe is not in favorites
                return;
            }

            // Remove the recipe from the user's favorites
            user.FavoriteRecipes.Remove(recipe);
            await context.SaveChangesAsync();
        }

        public void UpdateFavState(Recipe recipe)
        {
          
        }
    }
}
