using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Queries.Category.GetByIdCategory
{
    public class GetCategoryByIdQueryResponse
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
    }
}
