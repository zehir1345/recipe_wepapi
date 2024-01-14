using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Recipe.GetByIdRecipe
{
    public class GetByIdRecipeQueryRequest : IRequest<GetByIdRecipeQueryResponse>
    {
        public string Id { get; set; }
    }
}
