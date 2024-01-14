using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Recipe.GetAllReciipe
{
    public class GetAllRecipeQueryResponse
    {
        public int TotalCount { get; set; }
        public object Recipes { get; set; }
    }
}
