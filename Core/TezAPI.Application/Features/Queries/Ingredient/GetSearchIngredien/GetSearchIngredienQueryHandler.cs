using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Ingredient.GetSearchIngredien
{
    public class GetSearchIngredienQueryHandler : IRequestHandler<GetSearchIngredienQueryRequest, GetSearchIngredienQueryResponse>
    {
        readonly IIngredientReadRepository _ingredientReadRepository;

        public GetSearchIngredienQueryHandler(IIngredientReadRepository ingredientReadRepository)
        {
            _ingredientReadRepository = ingredientReadRepository;
        }

        public async Task<GetSearchIngredienQueryResponse> Handle(GetSearchIngredienQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _ingredientReadRepository.SearchIngredientsAsync(request.IngredientName);

            return new()
            {
                TotalCount = data.Count,
                Ingredients = data.ToList(),
            };
        }
    }
}
