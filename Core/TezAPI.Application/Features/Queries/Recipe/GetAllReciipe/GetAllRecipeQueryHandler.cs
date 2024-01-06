using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;
using TezAPI.Application.RequestParameters;

namespace TezAPI.Application.Features.Queries.Recipe.GetAllReciipe
{
    public class GetAllRecipeQueryHandler : IRequestHandler<GetAllRecipeQueryRequest, GetAllRecipeQueryResponse>
    {
        readonly private IRecipeReadRepository _recipeReadRepository;
        public GetAllRecipeQueryHandler(IRecipeReadRepository recipeReadRepository)
        {

            _recipeReadRepository = recipeReadRepository;

        }
        public async Task<GetAllRecipeQueryResponse> Handle(GetAllRecipeQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _recipeReadRepository.GetAll().Count();
            var response = _recipeReadRepository.GetAll().Skip(request.Page * request.Size).Take(request.Size).ToList();
            return new()
            {
                TotalCount = totalCount,
                Recipes = response

            };
        }

    }
}
