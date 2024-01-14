using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Ingredient.GetAllIngredients
{
    public class GetAllIngredientsQueryHandler : IRequestHandler<GetAllIngredientsQueryRequest, GetAllIngredientsQueryResponse>
    {
        readonly IIngredientReadRepository _ingredientReadRepository;

        public GetAllIngredientsQueryHandler(IIngredientReadRepository ingredientReadRepository)
        {
            _ingredientReadRepository = ingredientReadRepository;
        }

        public async Task<GetAllIngredientsQueryResponse> Handle(GetAllIngredientsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = _ingredientReadRepository.GetAll();
            return new()
            {
                TotalCount = data.Count(),
                Ingredients = data.ToList(),
            };
        }
    }
}
