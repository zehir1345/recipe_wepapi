using MediatR;
using TezAPI.Application.Repositories;

namespace TezAPI.Application.Features.Queries.Category.GetAllCategory
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, GetAllCategoriesQueryResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;

        public GetAllCategoriesQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetAllCategoriesQueryResponse> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
           var data = _categoryReadRepository.GetAll();
            return new()
            {
                TotalCount = data.Count(),
                Categories = data.ToList(),
            };
        }
    }
}
