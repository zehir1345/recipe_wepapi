using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Recipe.GetByIdRecipe
{
    public class GetByIdRecipeQueryHandler : IRequestHandler<GetByIdRecipeQueryRequest, GetByIdRecipeQueryResponse>
    {
        readonly private IRecipeReadRepository _recipeReadRepository;
        public GetByIdRecipeQueryHandler(IRecipeReadRepository recipeReadRepository)
        {
            _recipeReadRepository = recipeReadRepository;
        }
        public async Task<GetByIdRecipeQueryResponse> Handle(GetByIdRecipeQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _recipeReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = response.Id,
                UserId = response.UserId,
                RecipeText = response.RecipeText,
                CookingTime = response.CookingTime,
                PreparationTime = response.PreparationTime,
                Writer=response.Writer,
                //Categories = response.Categories,
                //Ingredients = response.Ingredients,
            };
        }
    }
}
