using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Ingredient.GetSearchIngredien
{
    public class GetSearchIngredienQueryResponse
    {
        public int TotalCount { get; set; }
        public object Ingredients { get; set; }
    }
}
