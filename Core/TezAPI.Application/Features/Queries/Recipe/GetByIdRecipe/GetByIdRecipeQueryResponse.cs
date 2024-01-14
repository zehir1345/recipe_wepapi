using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Domain.Entities;

namespace TezAPI.Application.Features.Queries.Recipe.GetByIdRecipe
{
    public class GetByIdRecipeQueryResponse
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string RecipeText { get; set; }
        public bool? IsItFavorite { get; set; }
        public int CookingTime { get; set; }
        public int PreparationTime { get; set; }
        public User? Writer { get; set; }
        public List<TezAPI.Domain.Entities.Category> Categories { get; set; } = new List<TezAPI.Domain.Entities.Category>();
        public List<TezAPI.Domain.Entities.Ingredient> Ingredients { get; set; } = new List<TezAPI.Domain.Entities.Ingredient>();
    }
}
