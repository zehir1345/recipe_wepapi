<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using TezAPI.Application.Repositories;
=======
﻿using TezAPI.Application.Repositories;
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository
{
    public class RecipeReadRepository : ReadRepository<Recipe>, IRecipeReadRepository
    {
<<<<<<< HEAD
        private readonly TezAPIDbContext context;
        public RecipeReadRepository(TezAPIDbContext context) : base(context)
        {
            context = context;
        }
        public List<Recipe> GetFavoriteRecipes(Guid userId)
        {
            var user = context.Set<User>().Find(userId);

            if (user == null)
            {
                // Handle the case where the user is not found
                return new List<Recipe>(); // veya null dönebilirsiniz, bu sizin tasarımınıza bağlı
            }

            // Kullanıcının favori tariflerini getir
            var favoriteRecipes = user.FavoriteRecipes.ToList();

            return favoriteRecipes;
        }

        public List<Recipe> GetRecentlyViewedRecipes(Guid userId, int count)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> SearchRecipes(string searchLetters)
        {
            if (string.IsNullOrEmpty(searchLetters))
            {
                // Eğer searchLetters boş veya null ise tüm tarifleri getir
                return context.Set<Recipe>().ToList();
            }

            // Küçük büyük harf duyarsız arama için ToLower() kullanabilirsiniz
            var searchLettersLower = searchLetters.ToLower();
            var matchingRecipes = context.Set<Recipe>()
                .Where(recipe => recipe.RecipeName.ToLower().Contains(searchLettersLower))
                .ToList();

            return matchingRecipes;
        }
        /*    public List<Recipe> GetRecentlyViewedRecipes(Guid userId, int count)
            {
                var user = context.Set<User>().Find(userId);

                if (user == null)
                {
                    // Handle the case where the user is not found
                    return new List<Recipe>();
                }

                // Kullanıcının son görüntülenen tarifleri getir
                var recentlyViewedRecipes = user.Recipes.OrderByDescending(r => r.LastViewedDateTime)
                                                        .Take(count)
                                                        .ToList();

                return recentlyViewedRecipes;
            }*/
=======
        public RecipeReadRepository(TezAPIDbContext context) : base(context)
        {
        }
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
    }
}
