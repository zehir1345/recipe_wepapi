using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Ingredient.GetSearchIngredien
{
    public class GetSearchIngredienQueryRequest : IRequest<GetSearchIngredienQueryResponse>
    {
        public string IngredientName { get; set; }
    }
}
