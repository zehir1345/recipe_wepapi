using TezAPI.Domain.Entities;

namespace TezAPI.Application.Repositories;

public interface IIngredientReadRepository:IReadRepository<Ingredient>
{
    Task<List<Ingredient>> SearchIngredientsAsync(string searchLetters);
}
