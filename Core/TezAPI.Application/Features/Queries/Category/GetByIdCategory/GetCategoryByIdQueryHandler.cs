using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Category.GetByIdCategory
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQueryRequest, GetCategoryByIdQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;

        public GetCategoryByIdQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetCategoryByIdQueryResponse> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data =await _categoryReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = data.Id,
                CategoryName = data.CategoryName,
            };
        }
    }
}
