using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.RequestParameters;

namespace TezAPI.Application.Features.Queries.Recipe.GetAllReciipe
{
    public class GetAllRecipeQueryRequest : IRequest<GetAllRecipeQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
