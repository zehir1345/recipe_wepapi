using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Category.GetAllCategory
{
    public class GetAllCategoriesQueryResponse
    {
        public int TotalCount { get; set; }
        public object Categories { get; set; }
    }
}
