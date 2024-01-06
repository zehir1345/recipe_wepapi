using Microsoft.EntityFrameworkCore;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class IngredientReadRepository : ReadRepository<Ingredient>, IIngredientReadRepository
{
    public IngredientReadRepository(TezAPIDbContext context) : base(context)
    {
    }
    public async Task<List<Ingredient>> SearchIngredientsAsync(string searchLetters)
    {
        if (string.IsNullOrEmpty(searchLetters))
        {
            // Eğer searchLetters boş veya null ise tüm malzemeleri getir
            return await Table.ToListAsync();
        }
        // Küçük büyük harf duyarsız arama için ToLower() kullanabilirsiniz
        var searchLettersLower = searchLetters.ToLower();
        var matchingIngredients = await Table
            .Where(ingredient => ingredient.IngredientName.ToLower().StartsWith(searchLettersLower))
            .ToListAsync();

        return matchingIngredients;
    }
}
